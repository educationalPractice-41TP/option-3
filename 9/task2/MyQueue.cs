namespace task2
{
    public class MyQueue<T>
    {
        private T[] _items;
        private int _head;
        private int _tail;
        private int _count;
        private const int InitialCapacity = 4;

        public MyQueue()
        {
            _items = new T[InitialCapacity];
            _head = 0;
            _tail = 0;
            _count = 0;
        }

        public void Enqueue(T item)
        {
            if (_count == _items.Length)
            {
                Resize();
            }

            _items[_tail] = item;
            _tail = (_tail + 1) % _items.Length;
            _count++;
        }

        public T Dequeue()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Очередь пуста.");
            }

            T item = _items[_head];
            _items[_head] = default(T); // Сброс значения
            _head = (_head + 1) % _items.Length;
            _count--;
            return item;
        }

        public T Peek()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Очередь пуста.");
            }
            return _items[_head];
        }

        public int Count => _count;

        private void Resize()
        {
            int newSize = _items.Length * 2;
            T[] newArray = new T[newSize];

            for (int i = 0; i < _count; i++)
            {
                newArray[i] = _items[(_head + i) % _items.Length];
            }

            _items = newArray;
            _head = 0;
            _tail = _count;
        }
    }
}
