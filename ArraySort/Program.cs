using System;

namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 5, 7, 11, -1, 0, 72, 100, 1};

            bool isSorted = false;

            // ascending Sort
            while (!isSorted)
            {
                for (int i = 0; i < numbers.Length -1; i++)
                {
                    if (numbers[i] > numbers[i+1])
                    {
                        int crrElement = numbers[i];
                        numbers[i] = numbers[i+1];
                        numbers[i+1] = crrElement;
                        
                    }

                }
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] <= numbers[j + 1])
                    {
                        isSorted = true;
                    }
                    else
                    {
                        isSorted = false;
                        break;
                    }
                }

            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Descending Sort.

            Console.WriteLine(new string('=', 15));

            int[] numberss = new int[] { 1, 5, 7, 11, -1, 0, 72, 100, 1 };

            bool isSortedDescending = false;
            
            while (!isSortedDescending)
            {
                for (int i = 0; i < numberss.Length - 1; i++)
                {
                    if (numberss[i] < numberss[i + 1])
                    {
                        int crrElement = numberss[i];
                        numberss[i] = numberss[i + 1];
                        numberss[i + 1] = crrElement;

                    }

                }
                for (int j = 0; j < numberss.Length - 1; j++)
                {
                    int crEl = numberss[j];
                    int crNexEl = numberss[j+1];
                    if (numberss[j] >= numberss[j + 1])
                    {
                        isSortedDescending = true;
                    }
                    else
                    {
                        isSortedDescending = false;
                        break;
                    }
                }

            }

            for (int i = 0; i < numberss.Length; i++)
            {
                Console.WriteLine(numberss[i]);
            }


        }
    }
}
