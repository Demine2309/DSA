namespace DSA
{
    #region Unordered Array implementation
    public class PriorityQueue<T> : Queue<T>
    {
        private Dictionary<T, int> _priorities;

        public PriorityQueue()
        {
            _priorities = new Dictionary<T, int>();
        }

        public void Enqueue(T item, int priority)
        {
            base.Enqueue(item);
            _priorities[item] = priority;
        }

        public T Dequeue()
        {
            var highestPriorityItem = _priorities.OrderByDescending(x => x.Value).FirstOrDefault();
            if (highestPriorityItem != null)
            {
                return highestPriorityItem.Key;
            }
            else
            {
                throw new InvalidOperationException("The queue is empty.");
            }
        }

        public int Count
        {
            get { return _priorities.Count; }
        }
    }
    #endregion
}