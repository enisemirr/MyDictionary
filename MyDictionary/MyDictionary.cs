using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] arrayKeys;
        TKey[] tempKeys;

        TValue[] arrayValues;
        TValue[] tempValues;

        public MyDictionary()
        {
            arrayKeys = new TKey[0];
            arrayValues = new TValue[0];

        }
        public void Add(TKey key, TValue value)
        {
            tempKeys = arrayKeys;
            tempValues = arrayValues;
            arrayKeys = new TKey[arrayKeys.Length+1];
            arrayValues = new TValue[arrayValues.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                arrayKeys[i] = tempKeys[i];                
            }
            for (int i = 0; i < tempValues.Length; i++)
            {
                arrayValues[i] = tempValues[i];
            }

            arrayKeys[arrayKeys.Length - 1] = key;
            arrayValues[arrayValues.Length - 1] = value;

            Console.WriteLine("ID :" + arrayKeys[arrayKeys.Length - 1] + "    Name :" + arrayValues[arrayValues.Length - 1] + "   listeye eklenmiştir!!!!!");
            Console.WriteLine("");

            for (int i = 0; i < arrayValues.Length; i++)
            {

                Console.WriteLine("ID :" + arrayKeys[i] + "    Name :" + arrayValues[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        
    }
}
