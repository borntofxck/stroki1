using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "C# обладает эффективными средствами обработки строк.";

            int x1 = str.IndexOf('о');
            int x2 = str.LastIndexOf('о');
            int x3 = str.IndexOf("ми");
            int x4 = str.LastIndexOf("ми");
            int x5 = str.IndexOfAny(new char[] { 'а', 'б', 'в' });

            bool startsWithSubstring = str.StartsWith("C# обладает");
            bool endsWithSubstring = str.EndsWith("строк.");

            Console.WriteLine("Индекс первого вхождения символа 'о': " + x1);
            Console.WriteLine("Индекс последнего вхождения символа 'о': " + x2);
            Console.WriteLine("Индекс первого вхождения подстроки \"ми\": " + x3);
            Console.WriteLine("Индекс последнего вхождения подстроки \"ми\": " + x4);
            Console.WriteLine("Индекс первого вхождения символов 'а', 'б' или 'в': " + x5);
            Console.WriteLine("Строка str начинается с подстроки \"C# обладает\" ");
            Console.WriteLine("Строка str оканчивается подстрокой \"строк\" ");
        }
    }
}
