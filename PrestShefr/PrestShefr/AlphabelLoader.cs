using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrestShefr
{
    public class AlphabelLoader
    {
        public static char[] alphabet { get; private set; }

        public static ObservableCollection<Pair<int>> pairs { get; private set; }

        static AlphabelLoader()
        {
            pairs = new ObservableCollection<Pair<int>>();
            Reload();
        }

        public static void Reload()
        {
            pairs.Clear();
            AlphabelLoader.alphabet = File.ReadAllText("Alphabet.txt").ToArray();
            for(int i = 1; i <= alphabet.Length; ++i)
            {
                if(alphabet.Length % i == 0)
                {
                    pairs.Add(Pair<int>.make_pair(alphabet.Length / i, i));
                }
            }
        }
    }
}
