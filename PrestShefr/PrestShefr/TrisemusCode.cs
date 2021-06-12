using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestShefr
{
    class TrisemusCode
    {
        public TrisemusCode(char[] alhabet, string k, Pair<int> size)
        {
            this.k = k;
            this.alhabet = new List<char>((k + alhabet).Distinct().ToArray());
            this.N = this.alhabet.Count;
            this.size = size;
        }

        private int N;
        public string k { get; private set; }
        public List<char> alhabet { get; private set; }

        public Pair<int> size { get; private set; }

        public char Code(char chr)
        {
            return alhabet.Contains(chr) ? alhabet[(alhabet.IndexOf(chr) + size.value2) % N] : chr;
        }

        public char Decode(char chr)
        {
            return alhabet.Contains(chr) ? alhabet[(alhabet.IndexOf(chr) + alhabet.Count - size.value2) % N] : chr;
        }
    }
}
