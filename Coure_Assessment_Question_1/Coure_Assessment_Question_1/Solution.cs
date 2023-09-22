using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coure_Assessment_Question_1
{
    public class Solution
    {
        public static int TotalScore(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 8)
                {
                    sum += 6;
                }
                else if(arr[i] % 2 == 0)
                {
                    sum++;
                }else
                {
                    sum += 3;
                }
            }

            return sum;
        }
    }
}
