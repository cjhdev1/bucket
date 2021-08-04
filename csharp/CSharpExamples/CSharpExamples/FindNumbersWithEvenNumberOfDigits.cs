using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    class FindNumbersWithEvenNumberOfDigits
    {
        public int FindNumbers(int[] nums)
        {
            int count = 0;

            // Going to loop through all the items in the array
            for (int i = 0; i < nums.Length; i++)
            {
                // Going to assign the first number to a variable
                int num = nums[i];

                // Going to convert that number to a string
                string str = num.ToString();

                // Going to get the length of that string and mod even on it so we know if
                // 0 is returned then we know it is a even length
                if (str.Length % 2 == 0)
                {
                    // So if even length then we up the counter
                    count++;
                }
            }

            // Return the count after the array loop
            return count;
        }
    }
}
