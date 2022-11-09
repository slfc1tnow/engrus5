using System;
using System.Linq;

namespace DotNetLab2._2
{
    public static class StringExtension
    {
        public static string ReverseString(this string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
  
        }
        public static int Count(this string input , char c)
        {
            return input.Split(c).Length - 1;
        }
      
    }


    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Reverse");

            Console.WriteLine("----");

            string str = "Reverse";
            string reverse = str.ReverseString();
            Console.WriteLine(reverse);

            Console.WriteLine("----");

            string input = "Reverse";
            int freq = input.Count('l');
            Console.WriteLine(freq);

            Console.WriteLine("----");

            Console.WriteLine("Array: 2, 5, 4, 4, 3, 1, 6");
            int[] array = new int[] { 2, 5, 4, 4, 3, 1, 6 };
            var k = 4;
            var col = array.Where(x => x == k).Count();
            Console.WriteLine($"Element 4 repeated {col} times");
            int[] distinct = array.Distinct().ToArray();

            Console.WriteLine(String.Join(",", distinct));
           


        }
       
    }
}
