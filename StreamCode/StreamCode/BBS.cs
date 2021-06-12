using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Numerics;

namespace StreamCode
{
    public class BBS
    {
        public BigInteger Q;
        public BigInteger P;
        public BigInteger N;

        public BigInteger X;

        public bool LastBit => X % 2 == 0;

        public BBS(byte[] q, byte[] p)
        {
            Q = new BigInteger(q);
            P = new BigInteger(p);
            N = Q * P;
            if (Q % 4 != 3 || P % 4 != 3)
                throw new Exception("Invalid Data");
            X = Q + 1;
        }

        public BBS(long q, long p)
        {
            Q = q;
            P = p;
            N = Q * P;
            if (Q % 4 != 3 || P % 4 != 3)
                throw new Exception("Invalid Data");
            X = Q + 1;
        }

        public void Next()
        {
            X = (X * X) % N;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Q := ").Append(Q).Append("\n").Append("P := ").Append(P).Append("\n")
              .Append("N := ").Append(N).Append("\n").Append("X0 := ").Append(X).Append("\n");
            return sb.ToString();
        }

        public static bool Validate(byte[] q, byte[] p)
        {
            BigInteger Q = new BigInteger(q);
            BigInteger P = new BigInteger(p);
            return !(Q % 4 != 3 || P % 4 != 3);
        }
        public static bool Validate(long q, long p)
        {
            BigInteger Q = new BigInteger(q);
            BigInteger P = new BigInteger(p);
            return !(Q % 4 != 3 || P % 4 != 3);
        }
    }
}
