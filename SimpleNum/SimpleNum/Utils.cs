using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNum
{
    public class Utils
    {
        public static int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }

        public static int gcd(int[] nums)
        {
            int ans = nums[0];
            foreach (int a in nums)
                ans = gcd(ans, a);
            return ans;
        }

        static List<uint> SieveEratosthenes(uint n)
        {
            var numbers = new List<uint>();
            //заполнение списка числами от 2 до n-1
            for (var i = 2u; i < n; i++)
            {
                numbers.Add(i);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2u; j < n; j++)
                {
                    //удаляем кратные числа из списка
                    numbers.Remove(numbers[i] * j);
                }
            }

            return numbers;
        }

        public static List<uint> SimplNums(uint m, uint n)
        {
            return SieveEratosthenes(n).Where(x => m <= x && x <= n).ToList();
        }
    }
}
