using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    public class MyDictionary<K, V>
    {
        KeyValuePair<K, V>[] _array;
        KeyValuePair<K, V>[] _TempArray;



        public MyDictionary()
        {
            _array = new KeyValuePair<K, V>[0];
        }

        public void Add(K id, V name)
        {
            

            if (KeyControl(id)==true)
            {
                _TempArray = _array;
                _array = new KeyValuePair<K, V>[_array.Length + 1];

                for (int i = 0; i < _TempArray.Length; i++)
                {
                    _array[i] = _TempArray[i];
                }
                _array[_array.Length-1] = new KeyValuePair<K, V>(id,name);
            }
            else
            {
                Console.WriteLine("Aynı key olduğu sürece ekleyemezsiniz : " +id);
            }

        }

        public int Count
        {
            get { return _array.Length; }
        }

        private bool KeyControl(K id)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Key.ToString() == id.ToString())
                {
                    return false;
                }
            }
            return true;            
        }

        public void ListItems()
        {
            for (int i = 0; i < _array.Length-1; i++)
            {
                Console.WriteLine("id :  " +_array[i].Key.ToString() + " isim : " + _array[i].Value.ToString());
                Console.WriteLine("***********************************************");
            }
        }

    }
}
