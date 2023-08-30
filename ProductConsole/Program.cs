//using ProductConsole;

////how to create object for class
//Product productObj = new Product();

//productObj.Name = "CPU";
//productObj.Description = "Computer";
//productObj.Price = 100;

//productObj.AddProduct();
//productObj.AddProduct(11, "CPU");
//productObj.AddProduct(12, "", 100);
//int result = productObj.GetSerial();
//Console.WriteLine();
//Console.Write();
//Console.WriteLine();
//int input = 5
//*
//**
//***
//****
//*****

using ProductConsole;

//Report objReport = new Report();
//PDFReport pDFReportObj=new PDFReport();
//pDFReportObj.GenerateReport();
//TextFileReport pTextFileReport = new TextFileReport();
//pTextFileReport.ReadReport();
//pTextFileReport.ReadReport();

Sales saleObj=new Sales();
saleObj.salesId = 101;
saleObj.name = "Test";
saleObj.amount = 100;
saleObj.salesDate=DateTime.Now;
//List<string> list = new List<string>();
//list.Add("Failed");
//list.Add("Success");
//list.Add("Dailed");

List<Sales> sales = new List<Sales>();
sales.Add(saleObj);

saleObj = new Sales();
saleObj.salesId = 102;
saleObj.name = "Test1";
saleObj.amount = 1000;
sales.Add(saleObj);
var a = 100;
var b = "100";
dynamic x = 100;
dynamic y = "100";
foreach (var s in sales)
{
    Console.WriteLine(s.amount); 
    Console.WriteLine(s.salesDate);
    Console.WriteLine(s.salesId);
    Console.WriteLine(s.name);
}
//saleObj.GetSalesDetails<string>("data");
//saleObj.GetSalesDetails<int>(100);
//saleObj.GetSalesDetails<bool>(true);


