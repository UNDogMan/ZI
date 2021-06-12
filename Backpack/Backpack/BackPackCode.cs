using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Backpack
{
    public class BackPackCode
    {
        private static readonly Random rand = new Random();

        public static BigInteger Gcd(BigInteger a, BigInteger b, out BigInteger x, out BigInteger y)
        {
            if (b < a)
            {
                var t = a;
                a = b;
                b = t;
            }

            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            BigInteger gcd = Gcd(b % a, a, out x, out y);

            BigInteger newY = x;
            BigInteger newX = y - (b / a) * x;

            x = newX;
            y = newY;
            return gcd;
        }

        public static BigInteger[] GenererateSuperAscendingSequence(int size, int count = 8)
        {
            var sq = new BigInteger[count];
            sq[count - 1] = 1;
            for(int i = 1; i < size; ++i)
            {
                sq[count - 1] = (sq[count - 1] << 1) + (rand.Next(0, 1000) > 500 ? 1 : 0);
            }
            for(int i = count - 2; i >= 0; --i)
            {
                sq[i] = sq[i + 1] >> 1;
            }
            return sq;
        }

        public BigInteger[] D;
        public BigInteger[] E;

        public BigInteger a;
        public BigInteger n;
        public BigInteger a1;

        public BackPackCode(int i = 100)
        {
            D = GenererateSuperAscendingSequence(i);
            n = D.Aggregate((x, y) => x + y) + 1;
            a = n - 2;
            BigInteger gd;
            BigInteger e;
            do
            {
                a -= rand.Next(1, 100);
                gd = BackPackCode.Gcd(a, n, out a1, out e);
            } while ((gd != 1) && (a*a1 % n != 1));
            if (a1 < 0) a1 += n;
            E = D.Select(d => d * a % n).ToArray();
        }

        public BigInteger[] Encode(byte[] message)
        {
            var codeMessage = new BigInteger[message.Length];
            
            for(int i = 0; i < message.Length; ++i)
            {
                var bits = new BitArray(new byte[] { message[i] });
                for(int j = 0; j < bits.Count; ++j)
                {
                    codeMessage[i] += bits[j] ? E[j] : 0;
                }
            }

            return codeMessage;
        }

        public byte[] Decode(BigInteger[] message)
        {
            byte ConvertToByte(BitArray bits)
            {
                if (bits.Count != 8)
                {
                    throw new ArgumentException("bits");
                }
                byte[] bytes = new byte[1];
                bits.CopyTo(bytes, 0);
                return bytes[0];
            }

            var decodeMessage = new byte[message.Length];
            message = message.Select(x => (x * a1) % n).ToArray();
            for (int i = 0; i < message.Length; ++i)
            {
                var bits = new BitArray(D.Length);
                for(int j = D.Length - 1; j >= 0; --j)
                {
                    if(message[i] >= D[j])
                    {
                        bits.Set(j, true);
                        message[i] -= D[j];
                    }
                }
                decodeMessage[i] = ConvertToByte(bits);
            }
            return decodeMessage;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("N = ").Append(n).Append("\n");
            sb.Append("a = ").Append(a).Append("\n");
            sb.Append("a1 = ").Append(a1).Append("\n");

            for(int i = 0; i < E.Length; ++i)
            {
                sb.Append("E" + i + " = ").Append(E[i]).Append("\n");
            }
            for (int i = 0; i < D.Length; ++i)
            {
                sb.Append("D" + i + " = ").Append(D[i]).Append("\n");
            }
            return sb.ToString();
        }
    }
}
