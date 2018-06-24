using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter1_Collection
{
    public class OriginCollection<T> : IEnumerable<T>
    {
        private T[] _items;
        private int _size;
        private readonly int _defaultCapacity = 4;

        public OriginCollection()
        {
            _items = new T[0];
            _size = 0;
        }

        public OriginCollection(int capacity)
        {
            Capacity = capacity;
            _size = 0;
        }

        public void Add(T item)
        {
            EnsureCapacity(_size + 1);
            _items[_size] = item;
            _size++;
        }

        public void Remove(T item)
        {
            var index = IndexOf(item);
            RemoveAt(index);
        }

        public int Count()
        {
            return _size;
        }

        public void Clear()
        {
            _items = new T[0];
            _size = 0;
        }

        public T this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
            }
        }

        public void Insert(int index, T item)
        {
            var length = _items.Length;
            EnsureCapacity(length + 1);
            T[] newItems = new T[length + 1];
            Array.Copy(_items, 0, newItems, 0, index);
            newItems[index] = item;
            Array.Copy(_items, index, newItems, index + 1, length - index);
            _size++;
        }

        public bool Contains(T item)
        {
            if (IndexOf(item) == -1)
            {
                return false;
            }
            return true;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            var length = _items.Length;
            for (int i = index; i < length - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            if (index != length - 1)
            {
                _items[length - 1] = default(T);
            }
            _size--;
        }

        private void EnsureCapacity(int min)
        {
            if (_items.Length < min)
            {
                var newCapacity = _items.Length == 0 ? _defaultCapacity : _items.Length * 2;
                if (newCapacity < min) newCapacity = min;
                Capacity = newCapacity;
            }
        }

        public int Capacity
        {
            get { return _items.Length; }
            set
            {
                if (value > 0)
                {
                    T[] newItems = new T[value];
                    Array.Copy(_items, newItems, _items.Length);
                    _items = newItems;
                }
                else
                {
                    _items = new T[0];
                }
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var e = new OriginEnumerator<T>(this);
            return e;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class OriginEnumerator<T> : IEnumerator,IEnumerator<T>
    {
        private OriginCollection<T> _collection;
        private int _position;
        public OriginEnumerator(OriginCollection<T> col)
        {
            _collection = col;
        }

        public Object Current
        {
            get
            {
                return _collection[_position];
            }
        }

        T IEnumerator<T>.Current
        {
            get
            {
                return _collection[_position];
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if(_position<_collection.Count())
            {
                _position++;
            }
            return _position < _collection.Count();
        }

        public void Reset()
        {

        }
    }
}
