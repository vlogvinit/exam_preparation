//Скласти програму для знаходження кількості входжень в текстовий рядок
//для кожного з різних символів текстового рядка
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Finde_Entry_text_From_Row
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Программа для підрахунку кількості входжень в рядок різних символів текстового рядка");
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
                foreach (var item in result)
                {
                    Console.WriteLine($"Символ - {item}, кількість входжень - {charElements.Where(x => x == item).Count()}");
                }
            }
            Console.ReadLine();
        }
    }
}
