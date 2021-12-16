using DIcontainer.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIcontainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new DiContainer();

            container.AddTransient<IA, A>();
            container.AddTransient<IB, B>();

           container.AddSingleton<ISomeService, SomeServiceOne>();       

            var serviceFirst = container.GetService<ISomeService>();
            var serviceSecond = container.GetService<ISomeService>();

            serviceFirst.PrintSomething();
            serviceSecond.PrintSomething();


            var FirstA = container.GetService<IA>();
        
        }
    }
}
