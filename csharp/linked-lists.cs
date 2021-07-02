using System;

// Installed "CS-Script" and "Mono Debug" extensions
// Had to also install .net core v5.0 for VSCODE run in terminal
// https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.301-windows-x64-installer

// This is a reference for linked lists in csharp

// Root
// [data][next]    [data][next]    [data][next]
//   5     >>>>>>>   17    >>>>>>>   8     End (null or none)

// Single linked lists
// Double linked lists
// Circular linked lists
// Linked lists with header Node

class Node
{
    public int info;
    public Node link;

    public Node(int i)
    {
        info = i;
        link = null;
    }
}

class SingleLinkedList
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
        for (i = 0; i < k-1 && p!=null; i++)
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

static void Main(string[] args)
{
    int choice, data, k, x;

    SingleLinkedList list = new SingleLinkedList();

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

        switch(choice)
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
}