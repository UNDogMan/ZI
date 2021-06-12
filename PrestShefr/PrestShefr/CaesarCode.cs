using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestShefr
{
    public class CaesarCode
    {
        public CaesarCode(int k, char[] alhabet)
        {
            this.k = k;
            this.alhabet = alhabet.ToList();
            this.N = alhabet.Length;
        }

        private int N;
        public int k { get; private set; }
        public List<char> alhabet { get; private set; }

        public char Code(char chr)
        {
            return alhabet.Contains(chr) ? alhabet[(alhabet.IndexOf(chr) + k) % N] : chr;
        }

        public char Decode(char chr)
        {
            return alhabet.Contains(chr) ? alhabet[(alhabet.IndexOf(chr) + alhabet.Count - k) % N] : chr;
        }
    }
}
