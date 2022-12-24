// See https://aka.ms/new-console-template for more information
using Spire.Doc;

Console.WriteLine("Hello, World!");

Document document = new Document();

var path = Directory.GetCurrentDirectory();
//Load a sample document
document.LoadFromFile(Directory.GetCurrentDirectory()+"//file.docx");

//Save to PDF
document.SaveToFile("Sample.pdf", FileFormat.PDF);
//Save to HTML
document.SaveToFile("toHTML.html", FileFormat.Html);
//Save to XPS
document.SaveToFile("Sample.xps", FileFormat.XPS);