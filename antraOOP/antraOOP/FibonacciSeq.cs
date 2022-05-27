using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antraOOP
{
    public class FibonacciSeq
    {
         public int fibonacci(int n = 0)
        {
            int[] nums = new int[n];
            nums[0] = 1;
            nums[1] = 1;
            for(int i = 2; i < n; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2];
            }

            return nums[n - 1];
        }
    }
}
