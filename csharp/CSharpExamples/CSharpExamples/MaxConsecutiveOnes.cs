using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    class MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int current = 0;

            foreach (int i in nums)
            {
                if (i == 1)
                {
                    current++;
                }
                else
                {
                    if (current > max)
                    {
                        max = current;
                    }
                    if (max >= nums.Length / 2)
                    {
                        return max;
                    }
                    current = 0;
                }
            }
            return Math.Max(max, current);
        }
        /**********
        [1,1,0,1,1,1]

        current = 1

        current = 2

        max = 2
        current = 0

        current = 1
        current = 2
        current = 3

        Return 3
        **********/

        /**********
        [1,0,1,1,0,1]

        current = 1

        max = 1
        current = 0

        current = 1
        current = 2

        max = 2
        current = 0

        current = 1

        Return 2
        **********/
    }
}
