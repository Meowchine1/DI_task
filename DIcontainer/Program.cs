using DIcontainer.DependencyInjection;


namespace DIcontainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new DiContainer();

            container.AddTransient<IA, A>();
            container.AddTransient<IB, B>();      
            container.AddTransient<C, C>();      

           container.AddSingleton<ISomeService, SomeServiceOne>();       

            var serviceFirst = container.GetService<ISomeService>();
            var serviceSecond = container.GetService<ISomeService>();          


            serviceFirst.PrintSomething();
            serviceSecond.PrintSomething();


            //var FirstA = container.GetService<IA>();
            var FirstC = container.GetService<C>();
           
        
        }
    }
}
