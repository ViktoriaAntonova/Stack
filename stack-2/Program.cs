using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace stack_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "{[()()]}";
            string b = Console.ReadLine();

            Console.WriteLine(IsValid(a));
            Console.WriteLine(IsValid(b);
        }
        static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    char open = stack.Pop();

                    if ((c == ')' && open != '(') ||
                        (c == '}' && open != '{') ||
                        (c == ']' && open != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
