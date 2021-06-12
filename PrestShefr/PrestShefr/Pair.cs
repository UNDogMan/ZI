using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestShefr
{
    public class Pair<T>
    {
        public T value1;
        public T value2;

        public static Pair<T> make_pair(T val1, T val2)
        {
            return new Pair<T> { value1 = val1, value2 = val2 };
        }

        public override string ToString()
        {
            return value1.ToString() + "*" + value2.ToString();
        }
    }
}
