using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    class ReplaceElementsWithGreatestElementOnRightSide
    {
        public int[] ReplaceElements(int[] arr)
        {
            int size = arr.Length;
            int MaxFromRight = arr[size - 1];

            arr[size - 1] = -1; //Right most always is -1

            for (int i = size - 2; i >= 0; i--)
            {
                //Going from right to left
                int temp = arr[i];
                arr[i] = MaxFromRight;

                if (MaxFromRight < temp)
                {
                    MaxFromRight = temp;
                }
            }

            return arr;
        }
    }
}
