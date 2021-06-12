using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab7
{
    static class Aditions
    {
        public static string DelLine(this string oldText)
        {
            int index = oldText.IndexOf(System.Environment.NewLine);
            return oldText.Substring(index + System.Environment.NewLine.Length);
        }
        public static bool IsPowerOfTwo(ulong x)
        {
            return (x & (x - 1)) == 0;
        }
        public static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
        public static IEnumerable<string> FullSplit(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize)).Concat(new string[] { str.Substring(str.Length - (str.Length % chunkSize), str.Length % chunkSize) });
        }

        public static string Complite(string str, int chunkSize)
        {
            if (str.Length % chunkSize != 0)
            {
                str = str + string.Join("", Enumerable.Range(0, chunkSize - str.Length % chunkSize).Select(i => '0'));
            }
            return str;
        }
        public static IEnumerable<string> SplitAndComplite(string str, int chunkSize)
        {   if (str.Length % chunkSize != 0)
            {
                str = str + string.Join("", Enumerable.Range(0, chunkSize - str.Length % chunkSize).Select(i => '0'));
            }
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }

        public static Vector<double> ToVectorDouble(this string str)
        {
            return Vector<double>.Build.DenseOfArray(str.Select(i => double.Parse(i.ToString())).ToArray());
        }
    }
}
