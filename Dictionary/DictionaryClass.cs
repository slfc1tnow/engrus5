using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Dictionary
{
    class DictionaryClass<Tkey,Tvalue> : IEnumerable
    {
        private List<Item<Tkey, Tvalue>> Items = new List<Item<Tkey, Tvalue>>();

        private List<Tkey> Keys = new List<Tkey>();
        public int Count => Items.Count;

        
       public DictionaryClass()
        {

        }
       
        public void Add(Item<Tkey, Tvalue> item)
        {
            if(!Keys.Contains(item.Key))
            {
                Keys.Add(item.Key);
                Items.Add(item);
            }
        }

        public Tvalue Search (Tkey key)
        {
            if (Keys.Contains(key))
            {
               return Items.Single(i => i.Key.Equals(key)).Value;
            }
            return default(Tvalue);
        }
        public void Remove(Tkey key)
        {
            if (Keys.Contains(key))
            {
               Keys.Remove(key); 
               Items.Remove(Items.Single(i => i.Key.Equals(key)));
            }
           
        }
       
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
