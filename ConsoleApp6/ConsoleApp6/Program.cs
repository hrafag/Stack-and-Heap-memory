using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 34, 5, 32, 7, 205, 4 };
            int result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= result)
                {
                    result = arr[i];
                }
                        }
            Console.WriteLine("the largest numbet is " + result);
        }
    }
}
