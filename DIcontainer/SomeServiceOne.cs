using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIcontainer
{
    public class SomeServiceOne : ISomeService
    {
        private readonly Guid RandomGuid = Guid.NewGuid();

        public void PrintSomething()
        {
            Console.WriteLine(RandomGuid);
        }
    }
}
