using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestShefr
{
    class SnakePermutation
    {
        public SnakePermutation(int s)
        {
            this.s = s;
        }

        public int s { get; private set; }

        public string Code(string str)
        {
            int n = str.Length;
            int k = n / s;
            if (n % s != 0) ++k;
            var list = str.ToList();
            for (int i = 1; i < k && i * s + s < n; i = i + 2)
            {
                list.Reverse(i * s, s);
            }
            return new string(list.ToArray());
        }

        public string Decode(string str)
        {
            return this.Code(str);
        }
    }
}
