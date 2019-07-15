//Замінити числом 5 елементи, менші від 5, парних номерів масиву
//натуральних чисел.
using System;
using System.Text;

namespace _2_Replace_5_in_massive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Программа для заміни числом 5 всіх парних елементів масиву менших 5");
            Console.ResetColor();
            Console.WriteLine("Введіть елементи масиву розділяючи їх пробілами:");
            string paragraph = Console.ReadLine();
            if (paragraph.Trim() == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ви ввели невірні дані");
                Console.ResetColor();
            }
            else
            {
                string[] stringElements = paragraph.Trim().Split(' ');
                for (int i = 0; i < stringElements.Length; i++)
                {
                    if ((i+1)%2 == 0 && Convert.ToInt16(stringElements[i]) < 5)
                    {
                        stringElements[i] = "5";
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Результат ");
                foreach (var item in stringElements)
                {
                    Console.Write($"{item} ");
                }
            }
            Console.ReadLine();
        }
    }
}
