using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProductConsole
{
    public class Sales
    {
        public int salesId { get; set; } //property
        public string name { get; set; }//property
        public int amount { get; set; }//property
        public DateTime salesDate { get; set; }//property

        //public int reportId; //field or variable

        public void GetSales()
        {
            
            int a = 10;
            string b = a.ToString();

            string c = "hai";
            object d = c;

            int[] salesid = new int[2]; //int array
            string[] saleName = new string[2]; //string array
            salesid[0] = 1;
            //salesid[1] = 2;
            saleName[0] = "Keyboard";
            //saleName[1] = "Mouse";
            ArrayList listObj= new ArrayList();
            listObj.Add(100);
            listObj.Add("Raj");
            listObj.Add(false);
            listObj.Add(true);
            for (int i = 0; i < listObj.Count; i++)
            {
                Console.WriteLine(listObj[i]);
            }
            foreach (var item in listObj)
            {
                Console.WriteLine(item);
            }
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push("Raj");
            stack.Push(true);

            Console.WriteLine(stack.Pop());

            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue("Raj");
            queue.Enqueue(true);

            Console.WriteLine(queue.Dequeue());
        }
        //Generic Collections
        //public void GetSalesDetails(int id)
        //{
        //    Console.WriteLine(id);
        //}
        //public void GetSalesDetails(string name)
        //{
        //    Console.WriteLine(name);
        //}
        //public void GetSalesDetails(bool flag)
        //{
        //    Console.WriteLine(flag);
        //}
        //public void GetSalesDetails(DateTime date)
        //{
        //    Console.WriteLine(date);
        //}

        public void GetSalesDetails<T>(T input)
        {
            Console.WriteLine(input);
        }
    }
}
