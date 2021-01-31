using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<K, V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempKey = keys; //geçici liste
            V[] tempValue = values; //geçici liste

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public void Write()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " ==> " + values[i]);
            }
        }
    }
}
