using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //to implement file handling.

namespace ProductConsole
{
    public abstract class Report
    {
        public abstract void GenerateReport();
    }
    public class PDFReport : Report
    {
        public override void GenerateReport()
        {
            Console.WriteLine("Pdf report generation");
        }
    }
    public class TextFileReport : Report
    {
        public override void GenerateReport()
        {
            Console.WriteLine("TextFile report generation");
            //File generation
            FileStream fs = new FileStream("salesreport.txt", FileMode.Create, FileAccess.Write);

            //how to write data into file
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("Welcome to e-mobile Shop");
            writer.WriteLine("Sales Report");
            writer.WriteLine("************");

            writer.Close();//close write operation
            fs.Close();//close file operation
        }

        public void ReadReport()
        {
            FileStream fs = new FileStream("salesreport.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);//read data
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
