using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "data_exp3.txt";
            int textLenght = 0;
            int k = 0;
            int words = 0;
            string[] textArray;                                     // массив для строки из текста
            string[] readText = File.ReadAllLines(path);            // массив для текста

            using (StreamReader sr = new StreamReader(path))
            {
                foreach (string s in readText)                          //перебор строк из текста 
                {
                    //Console.WriteLine("Строка {0}", s);
                    //Console.WriteLine(s.Length);
                    textLenght += s.Length;
                    k++;                                                // подчсет количества строк
                    textArray = s.Split(new char[] { ' ' });            // разбиение строки на слова
                    words += textArray.Length;
                }
            }
            Console.WriteLine("В тексте {0} символа(ов)", textLenght);
            Console.WriteLine("В тексте {0} строк(и)", readText.Length);
            Console.WriteLine("В тексте {0} слов(а)", words);
            Console.ReadKey();
        }
    }
}

