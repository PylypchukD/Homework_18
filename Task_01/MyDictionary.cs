using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class MyDictionary<TKey, TValue> : IEnumerable<object>, IEnumerator<object>, IDisposable
    {
        private List<TKey> keys = null;
        private List<TValue> values = null;
        private int position = -1;
        public MyDictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }

        public int Lenght
        {
            get
            {
                return keys.Count;
            }
        }

        public object Current
        {
            get
            {
                return $"{keys[position]} {values[position]}";
            }
        }

        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            if (position < keys.Count - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public string this[int index]
        {
            get
            {
                return $"{keys[index]} {values[index]}";
            }
        }
        public string this[TKey key]
        {
            get
            {
                for (int i = 0; i < keys.Count; i++)
                {
                    if ((string)(object)keys[i] == (string)(object)key)
                    {
                        return (string)(object)values[i];
                    }
                }
                return "Элемент не найден";
            }
        }


    }
}
