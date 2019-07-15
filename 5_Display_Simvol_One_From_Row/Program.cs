//Задано послідовність символів S1, S2,...Sn.Вивести символи, що входять в
//послідовність одноразово.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _5_Display_Simvol_One_From_Row
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Программа для знаходження унікальних символів послідовності");
            Console.ResetColor();
            Console.WriteLine("Введіть послідовність символів розділяючи їх пробілами:");
            string paragraph = Console.ReadLine();
            if (paragraph.Trim() == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ви ввели невірні дані");
                Console.ResetColor();
            }
            else
            {
                string[] paragraphElements = paragraph.Trim().Split(' ');
                List<string> result = paragraphElements.Distinct().ToList();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Унікальні елементи ");
                foreach (var item in result)
                {
                    if (paragraphElements.Where(x => x == item).Count() == 1)
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
