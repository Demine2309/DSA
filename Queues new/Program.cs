using System.Xml.Linq;

namespace DSA
{
    #region Simple Circular Array implementation
    //public class CircularQueue
    //{
    //	private int capacity;
    //	private int[] queue;
    //	private int front;
    //	private int rear;

    //	public CircularQueue(int capacity)
    //	{
    //		this.capacity = capacity;
    //		queue = new int[capacity];
    //		front = rear = -1;
    //	}

    //	public bool IsEmpty()
    //	{
    //		return front == -1;
    //	}

    //	public bool IsFull()
    //	{
    //		return (rear + 1) % capacity == front;
    //	}

    //	public void EnQueue(int data)
    //	{
    //		if(IsFull())
    //		{
    //			Console.WriteLine("Queue is full. Cannot enqueue");
    //			return;
    //		}
    //		else if(IsEmpty())
    //		{
    //			front = rear = 0;
    //		}
    //		else
    //		{
    //			rear = (rear + 1) % capacity;
    //		}

    //		queue[rear] = data;
    //	}

    //	public int DeQueue()
    //	{
    //		if (IsEmpty())
    //		{
    //               Console.WriteLine("Queue is empty. Cannot dequeue.");
    //               return -1; 
    //           }
    //		else if(front == rear)
    //		{
    //			int data = queue[front];
    //			front = rear = -1;
    //			return data;
    //		}
    //		else
    //		{
    //			int data = queue[front];
    //			front = (front + 1) % capacity;
    //			return data;
    //		}
    //	}

    //	public int Peek()
    //	{
    //           if (IsEmpty())
    //           {
    //               Console.WriteLine("Queue is empty.");
    //               return -1; // Return a default value
    //           }
    //           return queue[front];
    //       }

    //       public void Display()
    //       {
    //           if (IsEmpty())
    //           {
    //               Console.WriteLine("Queue is empty.");
    //               return;
    //           }
    //           int i = front;
    //           while (i != rear)
    //           {
    //               Console.Write(queue[i] + " ");
    //               i = (i + 1) % capacity;
    //           }
    //           Console.WriteLine(queue[rear]);
    //       }
    //   }

    //class MainClass
    //{
    //	static void Main(string[] args)
    //	{
    //		CircularQueue myQueue = new CircularQueue(5);
    //           myQueue.EnQueue(10);
    //           myQueue.EnQueue(20);
    //           myQueue.EnQueue(30);
    //           myQueue.EnQueue(40);

    //		myQueue.Display();

    //           Console.WriteLine("Front element: " + myQueue.Peek());
    //           Console.WriteLine("Dequeued: " + myQueue.DeQueue());
    //           myQueue.Display();

    //           Console.WriteLine("Is queue empty? " + myQueue.IsEmpty());
    //           Console.WriteLine("Is queue full? " + myQueue.IsFull());
    //       }
    //}
    #endregion

    #region Dynamic Circular Array implementation
    //public class CircularQueue<T>
    //{
    //    private T[] queue;
    //    private int front;
    //    private int rear;
    //    private int capacity;

    //    public CircularQueue(int initialCapacity)
    //    {
    //        capacity = initialCapacity;
    //        queue = new T[capacity];
    //        front = rear = -1;
    //    }

    //    public bool IsEmpty()
    //    {
    //        return front == -1;
    //    }

    //    public bool IsFull()
    //    {
    //        return (rear + 1) % capacity == front;
    //    }

    //    public void Enqueue(T data)
    //    {
    //        if (IsFull())
    //        {
    //            // Double the array size
    //            capacity *= 2;
    //            T[] newQueue = new T[capacity];
    //            for (int i = 0; i < queue.Length; i++)
    //            {
    //                newQueue[i] = queue[(front + i) % queue.Length];
    //            }

    //            queue = newQueue;
    //            front = 0;
    //            rear = queue.Length - 1;
    //        }

    //        if (IsEmpty())
    //        {
    //            front = rear = 0;
    //        }
    //        else
    //        {
    //            rear = (rear + 1) % capacity;
    //        }
    //        queue[rear] = data;
    //    }

    //    public T Dequeue()
    //    {
    //        if (IsEmpty())
    //        {
    //            throw new InvalidOperationException("Queue is empty.");
    //        }

    //        T dequeuedData = queue[front];

    //        if (front == rear)
    //        {
    //            front = rear = -1;
    //        }
    //        else
    //        {
    //            front = (front + 1) % capacity;
    //        }

    //        return dequeuedData;
    //    }

    //    public T Peek()
    //    {
    //        if (IsEmpty())
    //        {
    //            throw new InvalidOperationException("Queue is empty.");
    //        }
    //        return queue[front];
    //    }

    //    public int Size()
    //    {
    //        if (IsEmpty())
    //        {
    //            return 0;
    //        }
    //        return (rear - front + capacity) % capacity + 1;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        CircularQueue<int> queue = new CircularQueue<int>(4);
    //        queue.Enqueue(10);
    //        queue.Enqueue(20);
    //        queue.Enqueue(30);
    //        queue.Enqueue(40);

    //        Console.WriteLine("Queue size: " + queue.Size());
    //        Console.WriteLine("Front element: " + queue.Peek());
    //        Console.WriteLine("Dequeued: " + queue.Dequeue());
    //        Console.WriteLine("Queue size after dequeue: " + queue.Size());
    //    }
    //}
    #endregion

    #region Linked List implementation
    public class ListNode
    {
        public int data;
        public ListNode next;

        public ListNode(int d)
        {
            data = d;
            next = null;
        }
    }

    public class Queue
    {
        private ListNode front;
        private ListNode rear;

        public Queue()
        {
            front = null;
            rear = null;
        }

        public void EnQueue(int data)
        {
            ListNode newNode = new ListNode(data);

            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
        }

        public int DeQueue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int data = front.data;
            front = front.next;

            if (front == null)
            {
                rear = null;
            }

            return data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void DeleteQueue()
        {
            front = null;
            rear = null;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            ListNode current = front;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.EnQueue(10);
            queue.EnQueue(20);
            queue.EnQueue(30);

            queue.Display();

            Console.WriteLine(queue.DeQueue()); // Output: 10
            Console.WriteLine(queue.DeQueue()); // Output: 20

            queue.Display();

            Console.WriteLine(queue.IsEmpty()); // Output: False

            queue.DeleteQueue();

            Console.WriteLine(queue.IsEmpty()); // Output: True
        }
    }
    #endregion
}