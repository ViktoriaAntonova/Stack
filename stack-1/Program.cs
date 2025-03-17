using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] chars = text.ToCharArray();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                stack.Push(chars[i]);
            }
            foreach (char c in stack)
            {
                Console.Write(c);
            }
            Console.ReadKey();
        }
    }
}
