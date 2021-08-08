using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    class ValidMountainArray
    {
        public bool ValidMountainArrayCheck(int[] arr)
        {
            int i = 0;

            //First as long as our pointer i and +1 past it is less than the length of the array AND the current value is < that +1 then we know we are rising
            //on a mountain so keep going and increase that i pointer
            while (i < arr.Length && i + 1 < arr.Length && arr[i] < arr[i + 1])
            {
                i++;
            }

            if (i == 0 || i + 1 >= arr.Length)
            {
                return false;
            }

            //Next let's check again if we are in bounds of the array for our checks
            while (i < arr.Length && i + 1 < arr.Length)
            {
                if (arr[i] <= arr[i + 1])
                {
                    return false;
                }
                i++;
            }

            return true;
        }
    }
}
