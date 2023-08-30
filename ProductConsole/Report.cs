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
            //how to read input from user?
            //Console.ReadLine()
            Console.WriteLine("TextFile report generation");
            //File generation
            FileStream fs = new FileStream("salesreport.txt", FileMode.Create, FileAccess.Write);

            //how to write data into file
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("Welcome to e-mobile Shop");
            writer.WriteLine("Sales Report123");
            writer.WriteLine("************");
            Console.Write("Enter report name:");
            string reportName = Console.ReadLine();
            Console.Write("Enter report id:");
            int reportId =Convert.ToInt32(Console.ReadLine());
            writer.WriteLine("Report Name:" + reportName);
            writer.WriteLine("Report Id:" + reportId);
            writer.Close();//close write operation
            fs.Close();//close file operation
        }

        public void ReadReport()
        {
            FileStream fs = new FileStream("salesreport.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);//read data
            string line = reader.ReadLine();
            Console.WriteLine("ReportName\t\tReportId");
            while (reader.Peek() > 0)
            {
                if(line.StartsWith("Report Name"))
                {
                    //split function
                    string[] values = line.Split(':');
                    Console.Write(values[1]+"\t\t");
                }
                else if (line.StartsWith("Report Id"))
                {
                    //split function
                    string[] values = line.Split(':');
                    Console.WriteLine(values[1]);
                }
                line =reader.ReadLine();
            }
        }
    }
}
