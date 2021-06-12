using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestShefr
{
    class MultiPermutation
    {
        public class Trio<X, Y, Z>
        {
            public X item1;
            public Y item2;
            public Z item3;

            public Trio(X x, Y y, Z z)
            {
                item1 = x;
                item2 = y;
                item3 = z;
            }
        }
        public MultiPermutation(string key1, string key2)
        {
            this.key1 = key1;
            this.key2 = key2;

            key1tuples = new List<Trio<char, int, int>>();
            key2tuples = new List<Trio<char, int, int>>();

            for(int i = 0; i < key1.Length; ++i)
            {
                key1tuples.Add(new Trio<char, int, int>(key1[i], i, i));
            }
            for (int i = 0; i < key2.Length; ++i)
            {
                key2tuples.Add(new Trio<char, int, int>(key2[i], i, i));
            }

            key1tuples.Sort((x, y) => x.item1.CompareTo(y.item1));
            key2tuples.Sort((x, y) => x.item1.CompareTo(y.item1));
            for (int i = 0; i < key1.Length; ++i)
            {
                key1tuples[i].item3 = i;
            }
            for (int i = 0; i < key2.Length; ++i)
            {
                key2tuples[i].item3 = i;
            }
        }

        public string key1 { get; private set; }
        public string key2 { get; private set; }

        private List<Trio<char, int, int>> key1tuples;
        private List<Trio<char, int, int>> key2tuples;

        private string CodeBlock(string str)
        {
            if (str.Length > key1.Length * key2.Length)
                return string.Empty;
            if (str.Length < 2)
                return str;

            char[] ans = new char[key1.Length * key2.Length];
            ans.Populate(' ');
            int x, y;
            Trio<char, int, int> newx, newy;
            int n = key1.Length;
            int m = key2.Length;
            for(int i = 0; i < str.Length; ++i)
            {
                (x, y) = (i / m, i % m);
                newx = key1tuples.Find(j => j.item2 == x);
                newy = key2tuples.Find(j => j.item2 == y);

                ans[newx.item3 * m + newy.item3] = str[i];
            }

            return new string(ans);
        }

        private string DecodeBlock(string str)
        {
            if (str.Length > key1.Length * key2.Length)
                return string.Empty;
            if (str.Length < 2)
                return str;

            char[] ans = new char[key1.Length * key2.Length];
            ans.Populate(' ');
            int x, y;
            Trio<char, int, int> newx, newy;
            int n = key1.Length;
            int m = key2.Length;
            for (int i = 0; i < str.Length; ++i)
            {
                (x, y) = (i / m, i % m);
                newx = key1tuples[x];
                newy = key2tuples[y];

                ans[newx.item2 * m + newy.item2] = str[i];
            }

            return new string(ans);
        }

        public string Code(string str)
        {
            return string.Join("", str.Split(key1.Length * key2.Length).Select(x => this.CodeBlock(x)));
        }

        public string Decode(string str)
        {
            return string.Join("", str.Split(key1.Length * key2.Length).Select(x => this.DecodeBlock(x)));
        }
    }
}
