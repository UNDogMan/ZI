using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    static class Sets
    {
        static public bool NextSet(List<int> a, int n, int m)
        {
            int k = m;
            for (int i = k - 1; i >= 0; --i)
                if (a[i] < n - k + i + 1)
                {
                    ++a[i];
                    for (int j = i + 1; j < k; ++j)
                        a[j] = a[j - 1] + 1;
                    return true;
                }
            return false;
        }
    }
}
