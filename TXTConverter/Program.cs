using System;
using System.IO;
using Spire.Doc;

namespace CreateWordFromTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc;
            string fileNameWithoutExtension;
            string outputFilePath;

            Console.WriteLine("Enter the path of your input folder:");
            string inputFolder = Console.ReadLine();

            Console.WriteLine("Enter the path of your output folder:");
            string outputFolder = Console.ReadLine();
            outputFolder = String.Format(outputFolder + @"\");

            DirectoryInfo folder = new DirectoryInfo(inputFolder);
            foreach (FileInfo file in folder.GetFiles())
            {
                doc = new Document();
                doc.LoadText(file.FullName);
                fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file.FullName);
                outputFilePath = String.Format(outputFolder + fileNameWithoutExtension + ".docx");
                doc.SaveToFile(outputFilePath, FileFormat.Docx2013);
            }

        }
    }
}