using System;
using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(3);                
            list.AddLast(4);
            list.AddLast(5);
           
            
            // remove element 
            // count from 1

            int indexToRemove = 4;

            int counter = indexToRemove;

            Stack<int> stack = new Stack<int>();

            while (counter != 0)
            {
                foreach (var item in list)
                {
                    stack.Push(item);
                    list.RemoveFirst();
                    counter--;
                    break;

                }
            }
            
            stack.Pop();
            for (int i = 0; i < indexToRemove - 1; i++)
            {
                list.AddFirst(stack.Pop());
            }
                       

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
