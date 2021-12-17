using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIcontainer.DependencyInjection
{
    public class DiContainer
    {
        private List<ServiceDescriptor> _serviceDescriptors;


        public DiContainer()
        {
            _serviceDescriptors = new List<ServiceDescriptor>();
        }


        public void AddTransient<TService, TImplementation>()
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifeTime.Transient));
        }


        public void AddSingleton<TService, TImplementation>()
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation), ServiceLifeTime.Singleton));
        }


        public bool IsItCycled(Type serviceType, Type parametrType)
        {
            var descriptor = _serviceDescriptors
             .SingleOrDefault(x => x.ServiceType == parametrType);

            var actualParametrType = descriptor.ImplementationType;

            var constructorParametrType = actualParametrType.GetConstructors().First();


            if (constructorParametrType.GetParameters()
               .Any(x => Equals(serviceType, x.ParameterType)))
            {
                return true;
            }

            return false;

        }
       

        public object GetService(Type serviceType)
        {
            var descriptor = _serviceDescriptors
                .SingleOrDefault(x => x.ServiceType == serviceType);

            if (descriptor == null)
            {
                throw new Exception($"Service of type {serviceType.Name} isn't registerd");
            }

            if (descriptor.Implementation != null)
            {
                return descriptor.Implementation;
            }

            var actualType = descriptor.ImplementationType;

            var constructor = actualType.GetConstructors().First();

            if (constructor.GetParameters()
                .Any(x => IsItCycled(serviceType, x.ParameterType)))
            {
                throw new Exception($" Cyclic communication");
            }

            var parameters = constructor.GetParameters()
                .Select(x => GetService(x.ParameterType)).ToArray();



            var implementation = Activator
                .CreateInstance(actualType, parameters);

            if (descriptor.Lifetime == ServiceLifeTime.Singleton)
            {
                descriptor.Implementation = implementation;
            }

            return implementation;

        }
    

        public T GetService<T>() => (T)GetService(typeof(T));  
       
    }
}
