using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    public class HeapExample
    {
        IComparable[] element;
        int size;
        int maxSize;

        public HeapExample(int max)
        {
            maxSize = max;
            element = new IComparable[max];
            size = 0;
        }

        public bool Full { get { return size == maxSize; } }

        public bool Empty { get { return size == 0; } }

        public int Size { get { return size; } }

        public void Insert(IComparable item)
        {
            if (Full) throw new Exception("Heap is full.");
            int marker = size++;
            element[marker] = item;
            bubbleUp(marker);
        }
        
        public IComparable Peek()
        {
            if (Empty) throw new Exception("Heap is empty.");
            return element[0];
        }

        public void Remove()
        {
            if (Empty) throw new Exception("Heap is empty.");
            int parent = 0;
            int child1 = 1;
            int child2 = 2;
            int smallerChild = 0;
            while (child2 < size)
            {
                if (child2 == size)
                {
                    element[parent] = element[child1];
                    parent = child1;
                    child2++;
                }
                else
                {
                    if (element[child1].CompareTo(element[child2]) < 0)
                    {
                        smallerChild = child2;
                    }
                    else
                    {
                        smallerChild = child1;
                    }
                    element[parent] = element[smallerChild];
                    parent = smallerChild;
                    child1 = 2 * parent + 1;
                    child2 = 2 * parent + 2;
                }
            }
            element[parent] = element[--size];
            bubbleUp(parent);
        }

        private void bubbleUp(int marker)
        {
            int parent = (marker - 1) / 2;
            while (marker >= 1 && element[parent].CompareTo(element[marker]) < 0)
            {
                IComparable temp = element[marker];
                element[marker] = element[parent];
                element[parent] = temp;
                marker = parent;
                parent = (marker - 1) / 2;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < size; i++)
            {
                element[i] = null;
                size = 0;
            }
        }

        public override String ToString()
        {
            String s = "";
            for (int i = 0; i < size; i++)
            {
                s = s + " " + element[i].ToString();
            }
            return s;
        }
    }

    public class Sorter
    {
        public static void HeapSort(IComparable[] a, int size)
        {
            HeapExample heap = new HeapExample(a.Length);
            foreach (IComparable item in a) heap.Insert(item);
            for (int index = 0; index < a.Length; index++)
            {
                a[index] = heap.Peek();
                heap.Remove();
            }
        }
    }

    public class Searcher
    {
        public static int SequentialSearch(Object target, Object[] array, int size)
        {
            int location = -1;
            for (int index = 0; index < size; index++)
            {
                if (target.Equals(array[index]))
                {
                    location = index;
                }
            }

            return location;
        }

        public static int BinarySearch(IComparable target, IComparable[] array, int lo, int hi)
        {
            if (lo <= hi)
            {
                int mid = (lo + hi) / 2;

                if (array[mid].CompareTo(target) == 0)
                {
                    return mid;
                }
                else if(array[mid].CompareTo(target) > 0)
                {
                    return BinarySearch(target, array, mid + 1, hi);
                }
                else
                {
                    return BinarySearch(target, array, lo, mid - 1);
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
