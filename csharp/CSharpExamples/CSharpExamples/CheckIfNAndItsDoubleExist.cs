using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***
 * 
 *  Given an array arr of integers, check if there exists two integers N and M such that N is the double of M ( i.e. N = 2 * M).

    More formally check if there exists two indices i and j such that :

    i != j
    0 <= i, j < arr.length
    arr[i] == 2 * arr[j]
 * 
 * 
 */

namespace CSharpExamples
{
    class CheckIfNAndItsDoubleExist
    {
        public bool CheckIfExist(int[] arr)
        {
            //Example - [10,2,5,3]
            //O(n^2) solution since we are going through the array twice
            //Other examples to try is Treeset or Hashset solution to get better time complexity on Big O
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] * 2 == arr[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
