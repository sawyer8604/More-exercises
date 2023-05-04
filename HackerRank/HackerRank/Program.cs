using System;
using System.Collections.Generic;

namespace HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int counter = 0;
            bool isPrime = true;

            for (int i = 2; i < 100; i++)
            {
                isPrime = true;

                for (int j = 1; j < 100; j++)
                {
                    if(i % j == 0)
                    {
                        counter++;

                        if(counter > 2)
                        {
                            counter = 0;
                            isPrime = false;
                            break;
                        }
                    }

                }
                if(isPrime)
                {
                    numbers.Add(i);
                    counter = 0;                   
                }
                
                
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
