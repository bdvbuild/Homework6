using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
             * Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом 
             * без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
             */

            string str1 = Console.ReadLine();
            string strTemp = str1.ToLower().Replace(" ", "");
            string str2 = "";
            foreach (char c in strTemp)
            {
                str2 = c + str2;
            }
            if (str2 == strTemp)
            {
                Console.WriteLine("Предложение явяется палиндромом");
            } else
                Console.WriteLine("Предложение не является палиндромом");
            Console.ReadLine();
        }
    }
}
