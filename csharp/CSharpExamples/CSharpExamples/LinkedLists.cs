// This is a reference for linked lists in csharp. I tried to use VS Code for these but kept crashing with CS-Script so will instead switch these to VS Studio with a SLN.

// Root
// [data][next]    [data][next]    [data][next]
//   5     >>>>>>>   17    >>>>>>>   8     End (null or none)

// Single linked lists
// Double linked lists
// Circular linked lists
// Linked lists with header Node

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    class LinkedLists
    {
        public class Node
        {
            public int info;
            public Node link;

            public Node(int i)
            {
                info = i;
                link = null;
            }
        }

        public class SingleLinkedList
        {
            private Node start;

            public SingleLinkedList()
            {
                start = null;
            }

            public void DisplayList()
            {
                Node p;
                if (start == null)
                {
                    Console.WriteLine("List is empty...");
                    return;
                }

                Console.Write("List is: ");
                p = start;
                while (p != null)
                {
                    Console.Write(p.info + " > ");
                    p = p.link;
                }

                Console.WriteLine();
            }

            public void CountNodes()
            {
                int n = 0;
                Node p = start;
                while (p != null)
                {
                    n++;
                    p = p.link;
                }

                Console.WriteLine("Number of nodes in the list: " + n);
            }

            public bool Search(int x)
            {
                int position = 1;
                Node p = start;
                while (p != null)
                {
                    if (p.info == x)
                    {
                        break;
                    }
                    position++;
                    p = p.link;
                }
                if (p == null)
                {
                    Console.WriteLine("Not found: " + x);
                    return false;
                }
                else
                {
                    Console.WriteLine("Found: " + x + " at position: " + position);
                    return true;
                }
            }

            public void InsertInBeginning(int data)
            {
                Node temp = new Node(data);
                temp.link = start;
                start = temp;
            }

            public void InsertAtEnd(int data)
            {
                Node p;
                Node temp = new Node(data);

                if (start == null)
                {
                    start = temp;
                    return;
                }

                p = start;
                while (p.link != null)
                {
                    p = p.link;
                }

                p.link = temp;
            }

            public void InsertAfter(int data, int x)
            {
                Node p = start;
                while (p != null)
                {
                    if (p.info == x)
                    {
                        break;
                    }
                    p = p.link;
                }

                if (p == null)
                {
                    Console.WriteLine("Value note found in list: " + x);
                }
                else
                {
                    Node temp = new Node(data);
                    temp.link = p.link;
                    p.link = temp;
                }
            }

            public void InsertBefore(int data, int x)
            {
                Node temp;

                if (start == null)
                {
                    Console.WriteLine("List is Empty");
                    return;
                }

                // 
                if (x == start.info)
                {
                    temp = new Node(data);
                    temp.link = start;
                    start = temp;
                    return;
                }

                Node p = start;
                while (p.link != null)
                {
                    if (p.link.info == x)
                    {
                        break;
                    }
                    p = p.link;
                }

                if (p.link == null)
                {
                    Console.WriteLine("Not in the List: " + x);
                }
                else
                {
                    temp = new Node(data);
                    temp.link = p.link;
                    p.link = temp;
                }
            }

            public void InsertAtPosition(int data, int k)
            {
                Node temp;
                int i;

                if (k == 1)
                {
                    temp = new Node(data);
                    temp.link = start;
                    start = temp;
                    return;
                }

                Node p = start;
                for (i = 0; i < k - 1 && p != null; i++)
                {
                    p = p.link;
                }

                if (p == null)
                {
                    Console.WriteLine("You can insert only up to " + i + " position");
                }
                else
                {
                    temp = new Node(data);
                    temp.link = p.link;
                    p.link = temp;
                }
            }

            public void DeleteFirstNode()
            {
                if (start == null)
                {
                    return;
                }

                start = start.link;
            }

            public void DeleteLastNode()
            {
                if (start == null)
                {
                    return;
                }

                if (start.link == null)
                {
                    start = null;
                    return;
                }

                Node p = start;
                while (p.link.link != null)
                {
                    p = p.link;
                }

                p.link = null;
            }

            public void DeleteNode(int x)
            {
                if (start == null)
                {
                    Console.WriteLine("List is Empty\n");
                    return;
                }

                // Delete First Node
                if (start.info == x)
                {
                    start = start.link;
                    return;
                }

                // Delete Between or End
                Node p = start;
                while (p.link != null)
                {
                    if (p.link.info == x)
                    {
                        break;
                    }

                    p = p.link;
                }

                if (p.link == null)
                {
                    Console.WriteLine("Value: " + x + " Not in List");
                }
                else
                {
                    p.link = p.link.link;
                }
            }

            public void CreateList()
            {
                int i, n, data;

                Console.Write("Enter the number of nodes: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n == 0)
                {
                    return;
                }
                for (i = 0; i < n; i++)
                {
                    Console.Write("Enter the value to be inserted: ");
                    data = Convert.ToInt32(Console.ReadLine());
                    InsertAtEnd(data);
                }
            }
        }
    }
}