using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_katya
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = Dependencies.kernel.Get<ILogic>();
            logic.GetData();
        }
    }
}
