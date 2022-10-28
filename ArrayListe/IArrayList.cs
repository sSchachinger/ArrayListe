using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libArrayList
{
    public interface IArrayList<T>
    {

        /// <summary>
        /// Adds a specific item at the end of the array;
        /// </summary>
        /// <param name="item"></param>
        void Add(T item);
        /// <summary>
        /// Removes item at specific position 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        bool RemoveAt(int index);
        /// <summary>
        /// Removes specific value from from the array
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Remove(T item);
        /// <summary>
        /// Clear all items from the array
        /// </summary>
        /// <returns></returns>
        bool Clear();
        /// <summary>
        /// returns value from array
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T this[int index] { get; set; }
        /// <summary>
        /// returns length of the array
        /// </summary>
        int Count { get; }
        /// <summary>
        /// Insert a specific value at specific index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        void InsertAt(int index, T value);
        /// <summary>
        /// Gets the value by index
        /// </summary>
        /// <param name="index"></param>
        T Indexer(int index);
    }
}
