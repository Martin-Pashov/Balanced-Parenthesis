using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> parenthes = new Stack<char>();


            foreach (var symbol in input)
            {
                if (parenthes.Any())
                {
                    char check = parenthes.Peek();

                    if (check == '{' && symbol == '}')
                    {
                        parenthes.Pop();
                        continue;
                    }


                    else if (check == '[' && symbol == ']')
                    {
                        parenthes.Pop();
                        continue;
                    }


                    else if (check == '(' && symbol == ')')
                    {
                        parenthes.Pop();
                        continue;
                    }
                }
                parenthes.Push(symbol);
            }
            Console.WriteLine(!parenthes.Any() ? "YES" : "NO");
        }
    }
}