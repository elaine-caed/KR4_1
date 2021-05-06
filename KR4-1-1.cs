using System;

namespace KR4_1
{
    class Program
    {
        static void Fill(int[] arr) //метод для заповнення масиву випадковими значеннями
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 50);
            }
        }
        static void Write(int[] arr)
        {
            Console.Write("Your array: "); //метод для виводу масиву
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        static int Min(int[] arr) //метод для пошуку мінімального значення
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static int Max(int[] arr) //метод для пошуку максимального значення
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static int Average(int[] arr) //метод для знаходження середнього арифметичного значення
        {
            int i = 0;
            int sum = 0;
            while (i < arr.Length)
            {
                sum += arr[i];
                i++;
            }
            return sum / i;
        }
        static int Sum(int[] arr) //метод для знаходження суми значень
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Fill(array);
            Write(array);
            Console.WriteLine($"Min: {Min(array)}");
            Console.WriteLine($"Max: {Max(array)}");
            Console.WriteLine($"Average: {Average(array)}");
            Console.WriteLine($"Sum: {Sum(array)}");
        }
    }
}
