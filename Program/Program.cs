/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

using System;

namespace StringArrayFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "Hello", "2", "world", ":-)" };
            string[] resultArray = FilterStrings(inputArray);

            PrintArray(resultArray);  // Выведет: 2, :-)

            // Остальные примеры аналогичны
        }

        static string[] FilterStrings(string[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= 3)
                {
                    count++;
                }
            }

            string[] resultArray = new string[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= 3)
                {
                    resultArray[index] = arr[i];
                    index++;
                }
            }

            return resultArray;
        }

        static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
