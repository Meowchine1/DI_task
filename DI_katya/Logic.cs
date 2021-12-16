using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_katya
{
  public  interface ILogic
    {
        string GetData();
    }

 public   class Logic : ILogic
    {
        private IDAL _dal;

        public string GetData() => _dal.GetData();
        public Logic(IDAL dal)
        {
            _dal = dal;
        }
    }
}
