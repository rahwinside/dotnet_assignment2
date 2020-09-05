using System;
using System.Collections.Generic;

namespace Asst2
{
    public class Program10
    {
        public static void Main(string[] args)
        {
            int pushCount = int.Parse(Console.ReadLine());
            int popCount = int.Parse(Console.ReadLine());

            StringStack stack = new StringStack();

            for (int i = 0; i < pushCount; i++) {
                String val = Console.ReadLine();
                stack.push(val);
            }
            stack.printStack();

            for (int i = 0; i < popCount; i++)
            {
                stack.pop();
            }
            stack.printStack();

        }
    }

    interface Stack {
        void push(String val);
        void pop();
    }

    class StringStack : Stack
    {
        List<String> stack;

        public StringStack() {
            stack = new List<string>();
        }

        public void pop()
        {
            try
            {
                stack.RemoveAt(stack.Count - 1);
            }
            catch {
                Console.WriteLine("Stack is empty");
            }
        }

        public void push(string val)
        {

            if (stack.Count < 10)
                stack.Add(val);
            else
                Console.WriteLine("Stack is full");
        }

        public void printStack() {
            for (int i = stack.Count - 1; i > -1; i--) {
                Console.WriteLine(stack[i]);
            }
        }

    }
}
