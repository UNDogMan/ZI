using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    static class Aditions
    {
        public static string DelLine(this string oldText)
        {
            int index = oldText.IndexOf(System.Environment.NewLine);
            return oldText.Substring(index + System.Environment.NewLine.Length);
        }

        public static string PrintLine(this List<int> list)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var i in list)
            {
                stringBuilder.Append(i.ToString() + ' ');
            }
            return stringBuilder.ToString();
        }
    }
}
