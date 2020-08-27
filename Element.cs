using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 1; i <= countOrders; i++)
            {
                var elements = Console.ReadLine().Split(" ");
                var order = int.Parse(elements[0]);
                if (order == 1)
                {
                    var elemenTOpush = int.Parse(elements[1]);
                    numbers.Push(elemenTOpush);
                }
                else if (order == 2)
                {
                    if (numbers.Count != 0)
                    {
                        numbers.Pop();
                    }
                }
                else if (order == 3)
                {
                    if (numbers.Count!=0)
                    {
                    Console.WriteLine(numbers.Max());
                    }
                }
                else if (order == 4)
                {
                    if (numbers.Count != 0)
                    {
                    Console.WriteLine(numbers.Min());        
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers)) ;
            
        }
    }
}
