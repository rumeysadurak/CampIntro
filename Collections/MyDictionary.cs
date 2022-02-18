using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        //keys and values ​​are kept in two separate arrays. but the indexes of related key and value pairs are the same.
        public void Add(K key,V value)
        {
            K[] tempKeys = keys;
            keys = new K[keys.Length+1];
            V[] tempValues = values;
            values = new V[values.Length + 1];
            bool isThatKeyExist = false;

            for (int i = 0; i < tempKeys.Length; i++)
            {
                if (tempKeys[i].Equals(key))
                {
                    Console.WriteLine("This key already exists");
                    isThatKeyExist = true;
                    break;
                }
                
            }

            if (isThatKeyExist == false)
            {
                for (int i = 0; i < tempKeys.Length; i++)
                {
                    keys[i]= tempKeys[i];
                    values[i]= tempValues[i];
                }


                keys[keys.Length - 1] = key;
                values[values.Length - 1] = value;

            }
           
        }

        public void ShowAllKeyValuePairs()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i]+", "+values[i]);
            }
        }
      

    }
}
