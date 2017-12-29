using System;
using System.Collections;
using System.Collections.Generic;

namespace Mobile.Phone.Components.CallList {
    public class SortedList<T> : IList<T> where T : IComparable {
        private readonly List<T> objects = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return objects.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return objects.GetEnumerator();
        }

        public void Add(T item)
        {
            // TODO: simplify with binary search?
            objects.Add(item);
            objects.Sort(new DescendingComparer<T>());

        }

        private class DescendingComparer<T> : IComparer<T> where T : IComparable {
            public int Compare(T x, T y) {
                return y.CompareTo(x);
            }
        }

        public void Clear()
        {
            objects.Clear();
        }

        public bool Contains(T item)
        {
            return objects.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            objects.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return objects.Remove(item);
        }

        public int Count => objects.Count;
        public bool IsReadOnly => false;
        public int IndexOf(T item)
        {
            return objects.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            Add(item);
        }

        public void RemoveAt(int index)
        {
            objects.RemoveAt(index);
        }

        public T this[int index]
        {
            get { return objects[index]; }
            set { objects[index] = value; }
        }
    }
}
