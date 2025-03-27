namespace task2
{
    public class QueueProcessor<T>
    {
        private MyQueue<T> _queue;

        public QueueProcessor()
        {
            _queue = new MyQueue<T>();
        }

        public void AddTask(T task)
        {
            _queue.Enqueue(task);
            Console.WriteLine($"Задача добавлена: {task}");
        }

        public void ProcessTasks()
        {
            while (_queue.Count > 0)
            {
                T task = _queue.Dequeue();
                Console.WriteLine($"Выполняемая задача: {task}");
            }
        }

        public T PeekNextTask()
        {
            return _queue.Peek();
        }

        public int GetTaskCount()
        {
            return _queue.Count;
        }
    }
}
