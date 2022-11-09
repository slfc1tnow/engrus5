using System.Collections;

namespace Dictionary
{
    class Item<TKey,Tvalue>
    {
        public TKey Key { get; set; }
        public Tvalue Value { get; set; }

        public Item(TKey key , Tvalue value)
        {
            Key = key;
            Value = value;
        }

        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
        public override string ToString()
        {
            return Value.ToString();
        }
        

    }
}
