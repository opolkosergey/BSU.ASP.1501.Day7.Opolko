using System;

namespace Task3
{
    public class CustomQueue<T> 
    {
        public class QueueElement<T>
        {
            public T Value;
            public QueueElement<T> Next;
            public QueueElement(T value)
            {
                Value = value;
            }
        }

        public CustomQueue(T first)
        {
            First = new QueueElement<T>(first);
            Count++;
        }

        public int Count { get; private set; }
        private QueueElement<T> First;

        public T this[int index]
        {
            get
            {
                var temp = First;
                var i = 0;
                while (i != index)
                {
                    temp = temp.Next;
                    i++;
                }
                return temp.Value;
            }
        }
        public void Enqueue(T item)
        {
            if (First == null)
                throw new InvalidOperationException();
            if (item == null)
                throw new ArgumentNullException();

            var temp = First;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = new QueueElement<T>(item);
            Count++;
        }

        public T Dequeue()
        {
            if (First == null)
                throw new InvalidOperationException();
            var result = First.Value;
            First = First.Next;
            Count--;
            return result;
        }

        public T Peek()
        {
            if (First == null)
                throw new InvalidOperationException();
            return First.Value;
        }

        public CustomIterator GetEnumerator()
        {
            return new CustomIterator(this);
        }

        public struct CustomIterator
        {
            private readonly CustomQueue<T> collection;
            private int currentIndex;

            public CustomIterator(CustomQueue<T> collection)
            {
                this.currentIndex = -1;
                this.collection = collection;
            }

            public T Current
            {
                get
                {
                    if (currentIndex == -1 || currentIndex == collection.Count)
                    {
                        throw new InvalidOperationException();
                    }
                    return collection[currentIndex];
                }
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public bool MoveNext()
            {
                return ++currentIndex < collection.Count;
            }
        }
    }
}
