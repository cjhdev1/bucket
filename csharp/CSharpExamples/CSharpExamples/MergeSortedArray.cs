using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            m--;
            n--;

            int index = nums1.Length - 1;

            while (index >= 0)
            {
                if (m < 0)
                {
                    nums1[index] = nums2[n];
                    n--;
                }
                else if (n < 0)
                {
                    nums1[index] = nums1[m];
                    m--;
                }
                else
                {
                    if (nums1[m] > nums2[n])
                    {
                        nums1[index] = nums1[m];
                        m--;
                    }
                    else
                    {
                        nums1[index] = nums2[n];
                        n--;
                    }
                }

                index--;
            }
            Console.WriteLine("[{0}]", string.Join(", ", nums1));
        }
    }
}
