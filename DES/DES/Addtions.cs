using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES
{
    public static class Addtions
    {
        public static IEnumerable<string> SplitIntoChunks(this string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
        public static string AdditionNum(this string str)
        {
            return str.Count(x => x == '1') % 2 == 0 ? "1" : "0";
        }
    }
}
