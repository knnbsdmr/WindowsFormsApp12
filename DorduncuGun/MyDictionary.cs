using System;
using System.Collections.Generic;
using System.Text;

namespace DorduncuGun
{
    class MyDictionary<T1, T2>
    {
        private Dictionary<T1, T2> dictionary;

        public MyDictionary()
        {
            dictionary = new Dictionary<T1, T2>();
        }

        public void Add(T1 key, T2 value)
        {
            dictionary.Add(key, value);
        }
    }
}
