using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antraOOP
{
    public class ReverseNums
    {
        public int[] generateNumbers(int n = 10)
        {
            int[] nums = new int[n]; 
            for(int i = 0; i < n; i++)
            {
                nums[i] = i + 1;
            }
            return nums;
        }

        public void printNumbers(int[] nums)
        {
            foreach (int n in nums)
            {
                Console.Write(n + " ");
            }
        }

        public void reverse(int[] nums)
        {
            int len = nums.Length;
            int start = nums[0];
            int end = nums[len - 1];
            for (int i = 0; i < len/2; i++)
            {
                nums[i] = end;
                nums[len - i - 1] = start;
                end = nums[len - i - 2];
                start = nums[i + 1];
            }
        }
    }
}
