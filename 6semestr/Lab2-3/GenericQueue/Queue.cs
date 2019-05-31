using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericQueue
{
    public delegate void AddItemDelegate<TMyEventArgs>(object sender, TMyEventArgs e);
    //public delegate void RemoveItemDelegate(object sender, MyEventArgs e);
    //public delegate void GetHeadItemDelegate(object sender, EventArgs e);

    public class Queue<T> : IEnumerable<T>, ICollection
    {
        private List<T> _list;
        private int _head;
        private int _tail;
        private int _size;

        static readonly List<T> _emptyList = new List<T>(0);

        public Queue()
        {
            _list = _emptyList;
        }

        public Queue(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException("capacity");

            if (capacity == 0)
            {
                _list = _emptyList;
            }
            else
            {
                _list = new List<T>(capacity);
            }
        }

        public Queue(IEnumerable<T> collection) : this((collection == null ? 0 : collection.Count()))
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            using (IEnumerator<T> en = collection.GetEnumerator())
            {
                while (en.MoveNext())
                {
                    Enqueue(en.Current);
                }
            }
        }

        // Adds obj to the tail of the queue.
        public virtual void Enqueue(T item)
        {
            _list[_tail] = item;
            _tail = (_tail + 1) % _list.Count;
            _size++;

            AddItem?.Invoke(this, new MyEventArgs<T>(new object[1] {item}));
        }

        // Removes the object at the head of the queue and returns it. 
        public virtual T Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException("InvalidOperation_EmptyQueue");

            T removed = _list[_head];
            _list[_head] = default(T);
            _head = (_head + 1) % _list.Count;
            _size--;
            //RemoveItem?.Invoke(this, new MyEventArgs<T>(new object[1] {_list[_head]}));
            return removed;
        }

        // Returns the object at the head of the queue.
        public virtual T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("InvalidOperation_EmptyQueue");

            //GetHeadItem?.Invoke(this, new MyEventArgs<T>(new object[1]{ _list[_head]}));

            return _list[_head];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new QueueEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new QueueEnumerator(this);
        }

        public void CopyTo(Array array, int index)
        {
            if (array == null)
                throw new ArgumentNullException("array");
            if (index < 0 || index > array.Length)
                throw new ArgumentOutOfRangeException("index");

            T[] _array = new T[_list.Count];
            _list.CopyTo(_array);

            int numToCopy = _size;
            if (numToCopy == 0)
                return;
            int firstPart = (_list.Count - _head < numToCopy) ? _list.Count - _head : numToCopy;
            Array.Copy(_array, _head, array, index, firstPart);
            numToCopy -= firstPart;
            if (numToCopy > 0)
                Array.Copy(_array, 0, array, index + _array.Length - _head, numToCopy);
        }

        public virtual int Count
        {
            get { return _size; }
        }

        public object SyncRoot { get; }
        public bool IsSynchronized { get; }

        public struct QueueEnumerator : System.Collections.IEnumerator, IEnumerator<T>
        {
            private Queue<T> _queue;
            private int index;
            private T current;

            internal QueueEnumerator(Queue<T> queue)
            {
                this._queue = queue;
                index = 0;
                current = default(T);
                if (_queue._size == 0)
                    index = -1;
            }

            public bool MoveNext()
            {
                if (index == -2)
                    return false;

                index++;

                if (index == _queue._size)
                {
                    index = -2;
                    current = default(T);
                    return false;
                }

                current = _queue._list[index];
                return true;
            }

            public void Reset()
            {
                index = -1;
                current = default(T);
            }

            public T Current
            {
                get
                {
                    if (index < 0)
                    {
                        if (index == -1)
                            throw new InvalidOperationException("InvalidOperation_EnumNotStarted");
                        else
                            throw new InvalidOperationException("InvalidOperation_EnumEnded");
                    }

                    return current;
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }

        public event AddItemDelegate<MyEventArgs<T>> AddItem = null;
        //public event RemoveItemDelegate RemoveItem = null;
        //public event GetHeadItemDelegate GetHeadItem = null;
    }
}