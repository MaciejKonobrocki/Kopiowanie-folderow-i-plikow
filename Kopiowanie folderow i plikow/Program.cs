using System;

namespace Kopiowanie_folderow_i_plikow
{
    class Program
    {
        public class SimpleFileCopy
        {
            static void Main()
            {
                string fileName = "pliktestowy.txt";
                string sourcePath = @"C:\Users\Public\TestFolder";
                string targetPath = @"C:\Users\Public\TestFolder\SubDir";


                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);


                System.IO.Directory.CreateDirectory(targetPath);

                System.IO.File.Copy(sourceFile, destFile, true);

       
                if (System.IO.Directory.Exists(sourcePath))
                {
                    string[] files = System.IO.Directory.GetFiles(sourcePath);


                    foreach (string s in files)
                    {
                       .
                        fileName = System.IO.Path.GetFileName(s);
                        destFile = System.IO.Path.Combine(targetPath, fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
  
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
