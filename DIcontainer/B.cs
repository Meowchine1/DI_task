using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIcontainer
{
    public interface IB { }

    public class B : IB 
    {
        public B(IA A) { }
    }
}
