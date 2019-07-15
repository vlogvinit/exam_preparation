//Скласти програму, за допомогою якої обчислюється, скільки разів у
//заданому реченні зустрічається перше слово цього речення.
using System;
using System.Linq;
using System.Text;

namespace _8_Finde_Count_First_Word_In_Row
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Программа для обчислення, кількості входжень першого слова у заданому реченні");
            Console.ResetColor();
            Console.WriteLine("Введіть речення:");
            string paragraph =  Console.ReadLine();
            if (paragraph.Trim() == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ви ввели невірні дані");
                Console.ResetColor();
            } else
            {
                int count = 0;
                string[] paragraphElements = paragraph.Trim().Split(' ');
                string firstWord = (paragraphElements != null && paragraphElements.Length > 0) ? paragraphElements[0] : "";
                count = paragraphElements.Where(x => x == firstWord).Count();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Кількість входжень слова \"{ firstWord }\" в рядок - {count}");
            }
            Console.ReadLine();
        }
    }
}
