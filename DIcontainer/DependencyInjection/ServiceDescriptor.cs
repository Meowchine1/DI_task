using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIcontainer.DependencyInjection
{
  public  class ServiceDescriptor
    {
        public Type ServiceType { get;  }

        public Type ImplementationType { get; }

        public object Implementation { get; internal set; }

        public ServiceLifeTime Lifetime  { get;  }


        public ServiceDescriptor(Type serviceType, Type implementationType, ServiceLifeTime lifetime)
        {

            ServiceType = serviceType;

            Lifetime = lifetime;

            ImplementationType = implementationType;
        }

    }
}
