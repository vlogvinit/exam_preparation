//Скласти програму для виведення на екран всіх різних символів текстового
//рядка у порядку їх слідування в рядку
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Finde_Char_End_Display
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Программа для виведення різних символів текстового рядка");
            Console.ResetColor();
            Console.WriteLine("Введіть рядок:");
            string paragraph = Console.ReadLine();
            if (paragraph.Trim() == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ви ввели невірні дані");
                Console.ResetColor();
            }
            else
            {
                char[] charElements = paragraph.ToCharArray();
                List<char> result = charElements.Where(x => x != ' ').Distinct().ToList();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Різні символи ");
                foreach (var item in result)
                {
                    Console.Write($"{item} ");
                }
            }
            Console.ReadLine();
        }
    }
}
