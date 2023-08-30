using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductConsole
{
    interface IStock
    {
        void StockStatus();
        void StockCount(int productCode); 
    }
    public class Stock : IStock
    {
        public void StockCount(int productCode)
        {
            
        }

        public void StockStatus()
        {
            
        }
    }
}
