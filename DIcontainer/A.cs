using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIcontainer
{

    public interface IA { }


    public  class A : IA
    {
        public A(IB obj) { }

    }
}
