using System;//namespace
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductConsole
{
    //IMENo
    //CreditCard
    public class Product
    {
        //members
        public string Name;
        public int ProductId;
        private int ProductSerial;//Encapsulation
        public string Description;
        public int Price;

        //methods or functions
        //method declaration
        //Void methodname();

        //method definition
        //void methodname(){ }

        //method calling
        //methodname();
        //Void ->no return
        //return types->int,string,boolean,double,etc
        public void AddProduct()
        {
            Console.WriteLine("Add product");
        }
        public void AddProduct(int productid,string name)
        {
            Console.WriteLine("Productid:" + productid);
            Console.WriteLine("Productname:" + name);
            Console.WriteLine("**********");
        }
        public void AddProduct(int productid,string name,int price) 
        {
            Console.WriteLine("Productid:" + productid);
            Console.WriteLine("Productname:" + name);
            Console.WriteLine("Productprice:" + price);
            Console.WriteLine("**********");
        }
        public int GetSerial()
        {
            ProductSerial = 101;
            return ProductSerial;
        }
        public void GetReport(Report report)
        {
            report.GenerateReport();
        }
    }
}
