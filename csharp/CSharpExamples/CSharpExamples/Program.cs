// If there is a packages.json error on first build then goto Nuget Package Console and type "dotnet restore"

using System;
using System.Collections;

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
                Console.WriteLine("2. Stack Data Structure (FILO)");
                Console.WriteLine("3. Queue (FIFO)");
                Console.WriteLine("4. HeapSort and Search Example");
                Console.WriteLine("5. LeetCode: Max Consecutive Ones");
                Console.WriteLine("6. LeetCode: Find Numbers with Even Number of Digits");
                Console.WriteLine("7. LeetCode: Squares of a Sorted Array");
                Console.WriteLine("8. LeetCode: Duplicate Zeros");
                Console.WriteLine("9. LeetCode: Merge Sorted Array");
                Console.WriteLine("10. LeetCode: Remove Element");
                Console.WriteLine("11. LeetCode: Remove Duplicates From Sorted Array");
                Console.WriteLine("12. LeetCode: Check If N and Its Double Exist");
                Console.WriteLine("13. LeetCode: Valid Mountain Array");
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
                    case 3:
                        QueuePlaying();
                        break;
                    case 4:
                        HeapPlaying();
                        break;
                    case 5:
                        MaxConsecutiveOnes p = new MaxConsecutiveOnes();
                        int[] nums = new int[] { 1, 1, 0, 1, 1, 1 };
                        int Solution = p.FindMaxConsecutiveOnes(nums);
                        Console.WriteLine(Solution);
                        break;
                    case 6:
                        FindNumbersWithEvenNumberOfDigits p2 = new FindNumbersWithEvenNumberOfDigits();
                        int[] nums2 = new int[] { 12, 345, 2, 6, 7896 };
                        int Solution2 = p2.FindNumbers(nums2);
                        Console.WriteLine(Solution2);
                        break;
                    case 7:
                        SquaresOfASortedArray p3 = new SquaresOfASortedArray();
                        int[] nums3 = new int[] { -4, -1, 0, 3, 10 };
                        int[] Solution3 = p3.SortedSquares(nums3);
                        Console.WriteLine("[{0}]", string.Join(", ", Solution3));
                        break;
                    case 8:
                        DuplicateZeros p4 = new DuplicateZeros();
                        int[] nums4 = new int[] {1, 0, 2, 3, 0, 4, 5, 0};
                        p4.DuplicateZerosCall(nums4);
                        break;
                    case 9:
                        MergeSortedArray p5 = new MergeSortedArray();
                        int[] nums5 = new int[] { 1, 2, 3, 0, 0, 0 };
                        int[] nums6 = new int[] { 2, 5, 6 };
                        int n = 3;
                        int m = 3;
                        p5.Merge(nums5, m, nums6, n);
                        break;
                    case 10:
                        RemoveElement p6 = new RemoveElement();
                        int[] nums7 = new int[] { 3, 2, 2, 3 };
                        int nums8 = 3;
                        p6.RemoveElementNow(nums7, nums8);
                        break;
                    case 11:
                        RemoveDuplicatesFromSortedArray p7 = new RemoveDuplicatesFromSortedArray();
                        int[] nums9 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
                        int nums10 = p7.RemoveDuplicates(nums9);
                        Console.WriteLine(nums10);
                        break;
                    case 12:
                        CheckIfNAndItsDoubleExist p8 = new CheckIfNAndItsDoubleExist();
                        int[] nums11 = new int[] { 10, 2, 5, 3 };
                        bool Result1 = p8.CheckIfExist(nums11);
                        Console.WriteLine(Result1);
                        break;
                    case 13:
                        CheckIfNAndItsDoubleExist p9 = new CheckIfNAndItsDoubleExist();
                        int[] nums13 = new int[] { 2, 1 };
                        bool Result2 = p9.CheckIfExist(nums13);
                        Console.WriteLine(Result2);
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

            static void QueuePlaying()
            {
                Queue myQueue = new Queue();
                myQueue.Enqueue(100);
                myQueue.Enqueue(200);
                myQueue.Enqueue(300);
                myQueue.Enqueue(400);
                myQueue.Enqueue(500);
                myQueue.Enqueue("This is a string example");
                myQueue.Enqueue(null);

                Console.WriteLine("Number in the Queue: " + myQueue.Count);

                // If you want to just see the next value but not remove it then use "peek"
                foreach (var element in myQueue)
                {
                    Console.WriteLine(element);
                }

                // Dequeue will retrieve the first one entered and then remove it from the list
                while(myQueue.Count > 0)
                {
                    Console.WriteLine("Popping off the queue: " + myQueue.Dequeue());
                }

                // Should be 0 now
                Console.WriteLine("Number in the Queue: " + myQueue.Count);

                /************
                 *  Output:
                        Number in the Queue: 7
                        100
                        200
                        300
                        400
                        500
                        This is a string example

                        Popping off the queue: 100
                        Popping off the queue: 200
                        Popping off the queue: 300
                        Popping off the queue: 400
                        Popping off the queue: 500
                        Popping off the queue: This is a string example
                        Popping off the queue:
                        Number in the Queue: 0
                 ************/
            }

            static void HeapPlaying()
            {
                Random rnd = new Random();

                Console.Write("Enter # of ints to generate: ");
                int numInts = Int32.Parse(Console.ReadLine());
                IComparable[] array = new IComparable[numInts];
                IComparable[] array2 = new IComparable[numInts];

                for (int index = 0; index < array.Length; index++)
                {
                    array[index] = (IComparable)rnd.Next(array.Length);
                    array2[index] = array[index];
                }

                Console.WriteLine("Sorting the array.");
                Sorter.HeapSort(array2, array2.Length);

                bool goAgain = true;

                while(goAgain)
                {
                    goAgain = false;

                    Console.Write("Enter target int: ");
                    int target = Int32.Parse(Console.ReadLine());

                    int position = Searcher.SequentialSearch((IComparable)target, array, array.Length);
                    if (position > 0)
                    {
                        Console.WriteLine(target + " found at index " + position + " in the unsorted array.");
                    }
                    else
                    {
                        Console.WriteLine(target + " not found.");
                    }

                    position = Searcher.BinarySearch((IComparable)target, array2, 0, array2.Length - 1);
                    if (position > 0)
                    {
                        Console.WriteLine(target + " found at index " + position + " in the sorted array.");
                    }
                    else
                    {
                        Console.WriteLine(target + " not found.");
                    }
                }

                /**********
                 *  OUTPUT:
                     *  Choice: 4
                        Enter # of ints to generate: 100000000
                        Sorting the array.
                        Enter target int: 1
                        1 found at index 26438847 in the unsorted array.
                        1 found at index 99999999 in the sorted array.
                ********/
            }
        }
    }
}
