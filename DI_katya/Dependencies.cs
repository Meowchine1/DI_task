using Ninject;
using System;

namespace DI_katya
{
  public static  class Dependencies
    {   /// Кастомный диай контейнер
       /// private static IDAL dal = new DAL();
      ///  private static ILogic logic = new Logic(dal);

        public static readonly IKernel kernel = new StandardKernel();

        static Dependencies()
        {
            Configure();
        }

        public static void Configure()
        {
            kernel.Bind<IDAL>().To<DAL>();

            kernel.Bind<ILogic>().To<Logic>();
          
          
        }

      ///  public static IDAL GetDAL() => dal;

      ///  public static ILogic GetLogic() => logic;
      
       
    }

}
