using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            //Have to make sure we have a non-empty array
            if (nums.Length > 0)
            {
                //First number is always unique so just skip index 0 and go straight to 1
                int index = 1;

                //Loop through array
                //Example - [1,1,2]
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] != nums[i + 1])
                    {
                        nums[index] = nums[i + 1];
                        index++;
                    }
                }
                return index;
            }

            return 0;
        }
    }
}
