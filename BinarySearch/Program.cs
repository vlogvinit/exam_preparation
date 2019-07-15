//Здійснити бінарний пошук заданого елемента у впорядкованому за
//зростанням(за спаданням) масиві цілих чисел.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearch
{
    class Program
    {
        public static int BinarySearchBySorted(int[] inputArray, int key, Boolean orderByDesc = false)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (orderByDesc && key > inputArray[mid])
                {
                    max = mid - 1;
                }
                else if (!orderByDesc && key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
        public static void WriteResult(int findeElement, int result, Boolean sortedByDesc = false)
        {
            if (result < 0)
            {
                Console.WriteLine((sortedByDesc) ? $"Пошук елемента \"{findeElement}\" в відсортованому по спаданню масиві, не дав результатів" : $"Пошук елемента \"{findeElement}\" в відсортованому по зростанню масиві, не дав результатів");
            } else
            {
                Console.WriteLine((sortedByDesc) ? $"Пошук елемента \"{findeElement}\" в відсортованому по спаданню масиві, показав що елемент знаходиться під індексом {result}" : $"Пошук елемента \"{findeElement}\" в відсортованому по зростанню масиві, показав що елемент знаходиться під індексом {result}");
            }
            
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Программа для здійснення бінарного пошуку в відсортованому масиві");
            Console.ResetColor();
            Console.WriteLine("Введіть елементи масиву розділяючи їх пробілами:");
            string paragraph = Console.ReadLine();
            Console.WriteLine("Введіть елемент пошуку:");
            int findeElement = Convert.ToInt32(Console.ReadLine());
            if (paragraph.Trim() == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ви ввели невірні дані");
                Console.ResetColor();
            }
            else
            {
                string[] stringElements = paragraph.Trim().Split(' ');
                List<int> convertedValue = new List<int>();
                foreach (var item in stringElements)
                {
                    convertedValue.Add(Convert.ToInt16(item));
                }
                int[] sortedByDescendingValue = convertedValue.OrderByDescending(x => x).ToArray();
                int[] sortedByAscendingValue = convertedValue.OrderBy(x => x).ToArray();

                Console.ForegroundColor = ConsoleColor.Green;
                int resultSearchByDesc = BinarySearchBySorted(sortedByDescendingValue, findeElement, true);
                int resultSearchByAsc = BinarySearchBySorted(sortedByAscendingValue, findeElement);
                WriteResult(findeElement, resultSearchByDesc, true);
                WriteResult(findeElement, resultSearchByAsc);
            }
            Console.ReadLine();
        }
    }
}
