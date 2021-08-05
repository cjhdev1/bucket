using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    class DuplicateZeros
    {
        public void DuplicateZerosCall(int[] arr)
        {
            int arrLength = arr.Length;

            //[1,0,2,3,0,4,5,0]
            for (int i = arrLength - 1; i >= 0; i--) //We are going backwards first in the array to check for 0's
            {
                if(arr[i] == 0 && i != arrLength - 1)
                {
                    for(int j = arrLength - 1; j > i; j--)
                    {
                        if(j < arrLength - 1)
                        {
                            arr[j + 1] = arr[j];
                        }
                    }
                    arr[i + 1] = 0;
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
    }
}
