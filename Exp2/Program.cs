using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Exp2";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();                       // Создадим новый каталог C:\Exp2
            }
            string path_file = @"C:\Exp2\data.txt";
            if (!File.Exists(path_file))
            {
                File.Create(path_file);                       // Создадим Файл C:\Exp2\data.txt
            }
            using (StreamWriter data = new StreamWriter(path_file, false))   // false - режим перезаписи новых значений 
            {
                Random random = new Random();
                int s;
                for (int i = 0; i < 10; i++)
                {
                    s = random.Next(10, 90);
                    data.WriteLine(s);          // запись очередного случайного числа в файл
                }
            }
            Console.WriteLine("Текст записан в файл");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("В файл были записаны такие числа:");
            Console.WriteLine("-----------------------------------");
            int sum = 0; 
            int k; 
            string[] readText = File.ReadAllLines(path_file);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
                k = int.Parse(s.Trim());                 // преобразование string в int
                sum += k;
            }
            Console.WriteLine("Сумма чисел = {0}", sum);
            Console.ReadKey();
        }
    }
}
