// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());


        void InputOfDigits(int x, int y)
        {
            if (x > y)
            {
                return;
            }
            Console.Write($"{x}, ");
            InputOfDigits(x + 1, y);
        }

        InputOfDigits(M, N);

    }
}