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
TextFileReport pTextFileReport = new TextFileReport();
//pTextFileReport.GenerateReport();
pTextFileReport.ReadReport();

