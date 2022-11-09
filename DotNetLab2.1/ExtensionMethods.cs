using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetLab2._1
{
    static class ExtensionMethods
    {
        public static string Reverse(this string str)
        {
            string s = string.Empty;
            for (int i = str.Length - 1; i >= 0; --i)
                s += str[i];
            return s;
        }
    }
}
