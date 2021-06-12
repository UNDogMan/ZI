using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestShefr
{
    public static class Helper
    {
        public static void Populate<T>(this T[] arr, T value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
        }

        public static IEnumerable<string> Split(this string str, int chunkSize)
        {
            return Enumerable.Range(0, (int)Math.Ceiling((double)str.Length / chunkSize))
                .Select(i => str.Substring(i * chunkSize, (i + 1) * chunkSize <= str.Length ? chunkSize : str.Length - i * chunkSize));
        }


    }
}
