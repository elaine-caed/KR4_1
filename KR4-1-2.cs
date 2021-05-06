using System;

namespace KR4_1_2
{
    class Program
    {
        static void Fill(int[,] arr)// метод заповенення масиву рандомними значеннями
        { 
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(10, 56);
                }
            }
        }
        static void Write(int[,] mat)// метод виводу масиву
        { 
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static int Min(int[,] arr) //метод для пошуку мінімального значення
        {
            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[arr.GetLength(0) - 1 - i, i] < min)
                {
                    min = arr[arr.GetLength(0) - 1 - i, i];
                }
            }
            return min;
        }
        static int Max(int[,] arr) //метод для пошуку максимального значення
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                 if (arr[arr.GetLength(0) - 1 - i, i] > max)
                 {
                    max = arr[arr.GetLength(0) - 1 - i, i];
                 }
            }
            return max;
        }
        static int First(int[,] arr) //метод для пошуку першого входження мінімального значення
        {
            int min = arr[0, 0];
            int pos = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[arr.GetLength(0) - 1 - i, i] < min)
                {
                    min = arr[arr.GetLength(0) - 1 - i, i];
                }
                if (arr[arr.GetLength(0) - 1 - i, i] == min)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        static int Last(int[,] arr) //метод для пошуку останнього входження максимального значення
        {
            int max = arr[0, 0];
            int pos = -1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[arr.GetLength(0) - 1 - i, i] > max)
                {
                    max = arr[arr.GetLength(0) - 1 - i, i];
                }
            }
            int j = arr.GetLength(0) - 1;
            do
            {
                if (arr[arr.GetLength(0) - 1 - j, j] == max)
                {
                    pos = j;
                    j = -1;
                }
                else
                    j--;
            }
            while (j >= 0);
            return pos;
        }
        static void Swap(int[,] arr)// метод заміни значень стовбців
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int a = arr[i, Last(arr)];
                    arr[i, Last(arr)] = arr[i, First(arr)];
                    arr[i, First(arr)] = a;
            }
        }
        static void Main(string[] args)
        {
            int size = 10;
            int[,] array = new int[size, size];
            Fill(array);
            Write(array);
            Console.WriteLine($"Min: {Min(array)}");
            Console.WriteLine($"Max: {Max(array)}");
            Console.WriteLine($"First (min): {First(array)}");
            Console.WriteLine($"Last (max): {Last(array)}");
            Swap(array);
            Console.WriteLine("After swaping");
            Write(array);
        }
    }
}
