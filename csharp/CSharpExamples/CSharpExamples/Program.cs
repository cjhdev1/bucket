using System;

namespace CSharpExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Console.WriteLine("1. Linked Lists");
                Console.WriteLine("2. Stack Data Structure");
                Console.WriteLine("99. Quit");

                Console.Write("Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());


                if (choice == 99)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        LinkedListsMenu();
                        break;
                    case 2:
                        StackDataStructureMenu();
                        break;
                }



            }

            static void LinkedListsMenu()
            {
                #region LinkedLists Menu
                int choice, data, k, x;

                LinkedLists.SingleLinkedList list = new LinkedLists.SingleLinkedList();

                list.CreateList();

                while (true)
                {
                    Console.WriteLine("1. Display List");
                    Console.WriteLine("2. Count the Number of Nodes");
                    Console.WriteLine("3. Search List");
                    Console.WriteLine("4. Insert in Beginning of List");
                    Console.WriteLine("5. Insert at the End of the List");
                    Console.WriteLine("6. Insert After Specific Node");
                    Console.WriteLine("7. Insert Before Specific Node");
                    Console.WriteLine("8. Insert at Given Position");
                    Console.WriteLine("9. Delete the First");
                    Console.WriteLine("10. Delete the Last");
                    Console.WriteLine("11. Delete Any");
                    Console.WriteLine("12. Quit");

                    Console.Write("Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 12)
                    {
                        break;
                    }

                    switch (choice)
                    {
                        case 1:
                            list.DisplayList();
                            break;
                        case 2:
                            list.CountNodes();
                            break;
                        case 3:
                            Console.Write("Enter Search Value: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            list.Search(data);
                            break;
                        case 4:
                            Console.Write("Enter Value to be Inserted at Beginning: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            list.InsertInBeginning(data);
                            break;
                        case 5:
                            Console.Write("Enter Value to be Inserted at End: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            list.InsertAtEnd(data);
                            break;
                        case 6:
                            Console.Write("Enter Value to be Inserted: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Element After to be Inserted: ");
                            x = Convert.ToInt32(Console.ReadLine());
                            list.InsertAfter(data, x);
                            break;
                        case 7:
                            Console.Write("Enter Value to be Inserted: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Element Before to be Inserted: ");
                            x = Convert.ToInt32(Console.ReadLine());
                            list.InsertBefore(data, x);
                            break;
                        case 8:
                            Console.Write("Enter Value to be Inserted: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Position to be Inserted: ");
                            k = Convert.ToInt32(Console.ReadLine());
                            list.InsertAtPosition(data, k);
                            break;
                        case 9:
                            list.DeleteFirstNode();
                            break;
                        case 10:
                            list.DeleteLastNode();
                            break;
                        case 11:
                            Console.Write("Enter the Value to be Deleted: ");
                            data = Convert.ToInt32(Console.ReadLine());
                            list.DeleteNode(data);
                            break;
                    }
                }
                #endregion // end of MyRegion
            }

            static void StackDataStructureMenu()
            {
                bool exit = false;
                var stack = new StackDataStructure.Stack(10); // Limits to how big the stack can get.

                while (!exit)
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
        }
    }
}
