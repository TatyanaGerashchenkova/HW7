// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


void F(int M, int N)
{
    if(M != N)
    {
        if(M > N)
        {
            F(N - 1);
        System.Console.Write(N + " ");
        }
    }
    System.Console.Write(M + " ");
}

System.Console.WriteLine("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input M (<N!): ");
int M = Convert.ToInt32(Console.ReadLine());
F(M);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0 && m >0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        // Ввод значений m и n
        Console.Write("Input nonnegative number m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("input nonnegative number n: ");
        int n = int.Parse(Console.ReadLine());

        // Вычисление и вывод результата функции Аккермана
        int result = Ackermann(m, n);
        Console.WriteLine($"Result F Ackerman for m = {m} and n = {n}: {result}");
    }
}

// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void PrintArrayReversed(int[] array, int index)
    {
        // Если индекс равен -1 (вышли за пределы массива)
        if (index == -1)
        {
            return;
        }

        // Рекурсия: вывод текущего элемента и вызов функции для предыдущего элемента
        Console.Write(array[index] + " ");
        PrintArrayReversed(array, index - 1);
    }

    static void Main(string[] args)
    {
        // Произвольный массив
        int[] array = { 1, 2, 3, 4, 5 };

        // Вызов функции для печати элементов массива, начиная с конца
        PrintArrayReversed(array, array.Length - 1);
    }
}