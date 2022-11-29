using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libArrayList
{
    public class ArrayList<T> : IArrayList<T>
    {
        int _defaultlength;
        int _length;
        T[] array;

        public ArrayList()
        {
            array = new T[10];
            Count = 0;
        }
        public ArrayList(int length)
        {
            _length = _defaultlength = length;
            array = new T[length];
            Count = 0;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                array[index] = value;
            }
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (Count < _length / 2)
            {
                array[Count] = item;
                Count++;
            }
            else
            {
                Array.Resize(ref array, Count * 2);
                _length *= 2;
                array[Count] = item;
                Count++;
            }
        }

        public bool Clear()
        {
            array = null;
            array = new T[_defaultlength];
            return true;
        }

        public T Indexer(int index)
        {
            if (index > Count)
                throw new ArgumentOutOfRangeException("index");
            return array[index];
        }

        public void InsertAt(int index, T value)
        {
            if (index > _length)
            {
                Array.Resize(ref array, index);
                Count = _length = index;
            }
            T[] tmp = new T[Count + 1];
            Array.Copy(array, tmp, index);
            tmp[index] = value;
            Array.Copy(array, index, tmp, index + 1, Count - index);
            array = tmp;
            Count++;
        }

        public bool Remove(T item)
        {
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index].Equals(item))
                    RemoveAt(index);
            }
            return true;
        }

        public bool RemoveAt(int index)
        {
            T[] tmp = new T[Count];
            Array.Copy(array, tmp, index);
            Array.Copy(array, index + 1, tmp, index, Count - index - 1);
            array = tmp;

            return true;
        }


    }
}
