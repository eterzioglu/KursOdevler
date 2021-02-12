using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            keys = new TKey[keys.Length + 1];

            TValue[] tempValue = values;
            values = new TValue[values.Length + 1];

            for (int i = 0;i<tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[keys.Length - 1] = value;
        }

        public int Count
        {
            get { return keys.Length; }
        }

        public void List()
        {
            for(int i = 0; i < keys.Length;i++)
            {
                Console.WriteLine("key : " + keys[i] + " , value : " + values[i]);
            }
        }
    }
}
