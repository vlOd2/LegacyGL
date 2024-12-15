// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0


namespace System.Collections.Generic
{
    public class SynchronizedQueue<T> : IEnumerable<T>, ICollection, IEnumerable
    {
        private readonly Queue<T> queue = new Queue<T>();
        private readonly object @lock = new object();
        public int Count { get { lock (@lock) return queue.Count; } }
        public bool IsEmpty => Count == 0;
        public object SyncRoot => @lock;
        public bool IsSynchronized => true;

        public void Clear()
        {
            lock (@lock)
                queue.Clear();
        }

        public void Enqueue(T item)
        {
            lock (@lock)
                queue.Enqueue(item);
        }

        public T Dequeue()
        {
            lock (@lock)
            {
                if (queue.Count == 0)
                    return default;
                return queue.Dequeue();
            }
        }

        public T Peek()
        {
            lock (@lock)
            {
                if (queue.Count == 0)
                    return default;
                return queue.Peek();
            }
        }

        public bool Contains(T item)
        {
            lock (@lock)
                return queue.Contains(item);
        }

        public void CopyTo(Array array, int arrayIndex)
        {
            lock (@lock)
                ((ICollection)queue).CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            lock (@lock)
                return queue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            lock (@lock)
                return ((IEnumerable)queue).GetEnumerator();
        }
    }
}
