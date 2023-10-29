using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        PrintNumbers();
        PrintOdds();
        PrintSum();
        int[] array = { 1, 2, 3, 4, 5 };
        LoopArray(array);
        int[] maxArray = { -3, -5, -7 };
        int max = FindMax(maxArray);
        Console.WriteLine($"Valor maximo en el array: {max}");
        int[] avgArray = { 2, 10, 3 };
        GetAverage(avgArray);
        List<int> oddNumbersList = OddList();
        Console.WriteLine("Lista numeros inpares:");
        foreach (int num in oddNumbersList)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        List<int> greaterThanYList = new List<int> { 1, 3, 5, 7 };
        int count = GreaterThanY(greaterThanYList, 3);
        Console.WriteLine($"Numeros mas grandes que Y: {count}");
        List<int> squareArray = new List<int> { 1, 5, 10, -10 };
        SquareArrayValues(squareArray);
        Console.WriteLine("array Cuadrada:");
        foreach (int num in squareArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        List<int> eliminateNegativesList = new List<int> { 1, 5, 10, -2 };
        EliminateNegatives(eliminateNegativesList);
        Console.WriteLine("Lista negativos Eliminados:");
        foreach (int num in eliminateNegativesList)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 255; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void PrintOdds()
    {
        for (int i = 1; i <= 255; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    static void PrintSum()
    {
        int sum = 0;
        for (int i = 0; i <= 255; i++)
        {
            sum += i;
            Console.WriteLine($"Nuevo numero: {i} Suma: {sum}");
        }
    }

    static void LoopArray(int[] numbers)
    {
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }

    static int FindMax(int[] numbers)
    {
        int max = int.MinValue;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    static void GetAverage(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        double average = (double)sum / numbers.Length;
        Console.WriteLine($"Promedio: {average}");
    }

    static List<int> OddList()
    {
        List<int> oddNumbers = new List<int>();
        for (int i = 1; i <= 255; i += 2)
        {
            oddNumbers.Add(i);
        }
        return oddNumbers;
    }

    static int GreaterThanY(List<int> numbers, int y)
    {
        int count = 0;
        foreach (int num in numbers)
        {
            if (num > y)
            {
                count++;
            }
        }
        return count;
    }

    static void SquareArrayValues(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] = numbers[i] * numbers[i];
        }
    }

    static void EliminateNegatives(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < 0)
            {
                numbers[i] = 0;
            }
        }
    }
}
