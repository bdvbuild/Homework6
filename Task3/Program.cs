using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. 
             * В строке может быть несколько фрагментов, заключённых в фигурные скобки. 
             * Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
            */

            string str = Console.ReadLine();
            bool par = str.Contains("{") && str.Contains("}");
            int n = 0;
            int k = n+1;

            while (par)
            {
                int found1 = str.IndexOf("{", n);
                int found3 = str.IndexOf("{", found1 + 1);
                int found2 = str.IndexOf("}", k);
                if ((found3 > found2) || (found3 == -1))
                {
                    str = str.Remove(found1, found2 - found1 + 1);
                    n = 0;
                } else n++;
                par = str.Contains("{") && str.Contains("}");
            }
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
