using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    class RemoveElement
    {
        public int RemoveElementNow(int[] nums, int val)
        {
            int index = 0;

            //[3,2,2,3]
            //3
            foreach (int i in nums)
            {
                if (i != val)
                {
                    nums[index] = i; //First time, nums @ 0 index will get that 2 because it != 3 (in this example)
                    index++;
                }
            }

            return index;
        }
    }
}
