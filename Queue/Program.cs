namespace DSA
{
    public class Queue
    {
        private int[] arr;
        private int capacity;
        private int rear, front;

        public Queue(int size)
        {
            arr = new int[size];
            capacity = size;
            front = -1;
            rear = -1;
        }

        public void EnQueue(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full!!!!");
            }
            else
            {
                if(front == -1)
                    front = 0;
                rear++;
                arr[rear] = value;
                Console.WriteLine("Inserted " + value);
            }
        }

        public int DeQueue()
        {
            int value;
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!!!");
                return -1;
            }
            else
            {
                value = arr[front];
                if(front >= rear) 
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front++;
                }
                Console.WriteLine("Deleted -> " + value);
                return value;
            }
        }

        public bool IsFull()
        {
            if(front == 0 && rear == capacity - 1)
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            if(front == -1)
                return true;
            else
                return false;
        }

        public void PrintQueue()
        {
            for (int i = front; i <= rear; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(5);

            queue.DeQueue();

            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            queue.EnQueue(4);
            queue.EnQueue(5);
            queue.EnQueue(6);

            queue.PrintQueue();

            queue.DeQueue();
            Console.WriteLine("Before dequeueing...");
            queue.PrintQueue();
            Console.ReadKey();
        }
    }
}