using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"C:\Autodesk";
            if (Directory.Exists(dirName))
            {
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)            // перебираем каталоги
                {
                    Console.WriteLine("Подкаталог:");
                    Console.WriteLine(s);
                    Console.WriteLine("* * * * * * * * * * * * * * * * * ");
                    
                    string[] files = Directory.GetFiles(s);
                    Console.WriteLine("Файлы каталога {0}:", s);
                         foreach (string k in files)            // перебираем файлы текущего каталога
                             Console.WriteLine(k);
                    Console.WriteLine();
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }

}
