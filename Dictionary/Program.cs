using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{

    class Program
    {
        static void Main(string[] args)
        {
            var DictionaryClass = new DictionaryClass<int, string>();
            DictionaryClass.Add(new Item<int, string>(1, "One"));
            DictionaryClass.Add(new Item<int, string>(2, "Two"));
            DictionaryClass.Add(new Item<int, string>(3, "Three"));
            DictionaryClass.Add(new Item<int, string>(4, "Four"));
            DictionaryClass.Add(new Item<int, string>(5, "Five"));
         

            foreach (var item in DictionaryClass)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(DictionaryClass.Search(7) ?? "Not found");
            Console.WriteLine(DictionaryClass.Search(1) ?? "Not found");

            DictionaryClass.Remove(3);
            DictionaryClass.Remove(1);



            foreach (var item in DictionaryClass)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
