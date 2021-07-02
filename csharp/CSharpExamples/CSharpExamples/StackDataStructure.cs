using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    public class StackDataStructure
    {
        public class Stack
        {
            public int Count { get; private set; }
            private int[] stack;

            public Stack(int size)
            {
                stack = new int[size];
                Count = 0;
            }

            public void Push(int n)
            {
                if (Count == stack.Length)
                {
                    Console.WriteLine("Stack is full...");
                }
                else
                {
                    stack[Count++] = n;
                }
            }

            public int Pop()
            {
                int result = -1;

                if (Count == 0)
                {
                    Console.WriteLine("Stack is empty...");
                }
                else
                {
                    result = stack[--Count];
                }

                return result;
            }

            public void Display()
            {
                if (Count == 0)
                {
                    Console.WriteLine("Stack is empty...");
                }
                else
                {
                    Console.WriteLine("Stack data:");
                    for (int i = Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                }
            }
        }
    }
}

//1. Push
//2. Pop
//3. Display Stack
//1
//Number: 11

//1. Push
//2. Pop
//3. Display Stack
//1
//Number: 12

//1. Push
//2. Pop
//3. Display Stack
//1
//Number: 13

//1. Push
//2. Pop
//3. Display Stack
//2
//Popping data: 13

//1. Push
//2. Pop
//3. Display Stack
//2
//Popping data: 12

//1. Push
//2. Pop
//3. Display Stack
//2
//Popping data: 11

//1. Push
//2. Pop
//3. Display Stack
//3
//Stack is empty...

//1. Push
//2. Pop
//3. Display Stack
//***********/