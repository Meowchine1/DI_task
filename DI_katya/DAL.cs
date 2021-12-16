using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_katya
{
 public   interface IDAL
    {
        string GetData();
    }

  public  class DAL : IDAL
    {
        public string GetData() => Guid.NewGuid().ToString();
    }
}
