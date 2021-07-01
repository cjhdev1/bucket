// Installed "CS-Script" and "Mono Debug" extensions
// Had to also install .net core v5.0 for VSCODE run in terminal
// https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.301-windows-x64-installer

using System;

class Script
{
    static void Main(string[] args)
    {
        bool exit = false;
        var stack = new Stack(10);

        while(!exit)
        {
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Display Stack");

            var key = Console.ReadKey();
            char operation = key.KeyChar;

            Console.WriteLine();

            int n;

            switch (operation)
            {
                case '1':
                    Console.Write("Number: ");
                    var line = Console.ReadLine();

                    if (int.TryParse(line, out n))
                    {
                        stack.Push(n);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input...");
                    }
                    break;

                case '2':
                    n = stack.Pop();
                    Console.WriteLine($"Popping data: {n}");
                    break;
                
                case '3':
                    stack.Display();
                    break;

                default:
                    Console.WriteLine("Exiting...");
                    exit = true;
                    break;
            }

            Console.WriteLine();
        }
    }

    class Stack
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

/***********
Output

C:\> dotnet "C:\Users\hi_000\AppData\Roaming\Code\User\cs-script.user\dotnet\cscs.dll" "c:\Users\hi_000\sourcecode\bucket\csharp\stack-data-structure.cs"
1. Push
2. Pop
3. Display Stack
1
Number: 11

1. Push
2. Pop
3. Display Stack
1
Number: 12

1. Push
2. Pop
3. Display Stack
1
Number: 13

1. Push
2. Pop
3. Display Stack
2
Popping data: 13

1. Push
2. Pop
3. Display Stack
2
Popping data: 12

1. Push
2. Pop
3. Display Stack
2
Popping data: 11

1. Push
2. Pop
3. Display Stack
3
Stack is empty...

1. Push
2. Pop
3. Display Stack
***********/