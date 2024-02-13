using System.Collections;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace DSA
{
    #region Queue
    //public class Queue
    //{
    //    private int[] arr;
    //    private int capacity;
    //    private int rear, front;

    //    public Queue(int size)
    //    {
    //        arr = new int[size];
    //        capacity = size;
    //        front = -1;
    //        rear = -1;
    //    }

    //    public void EnQueue(int value)
    //    {
    //        if (IsFull())
    //        {
    //            Console.WriteLine("Queue is full!!!!");
    //        }
    //        else
    //        {
    //            if (front == -1)
    //                front = 0;
    //            rear++;
    //            arr[rear] = value;
    //            Console.WriteLine("Inserted " + value);
    //        }
    //    }

    //    public int DeQueue()
    //    {
    //        int value;
    //        if (IsEmpty())
    //        {
    //            Console.WriteLine("Queue is empty!!!");
    //            return -1;
    //        }
    //        else
    //        {
    //            value = arr[front];
    //            if (front >= rear)
    //            {
    //                front = -1;
    //                rear = -1;
    //            }
    //            else
    //            {
    //                front++;
    //            }
    //            Console.WriteLine("Deleted -> " + value);
    //            return value;
    //        }
    //    }

    //    public bool IsFull()
    //    {
    //        if (front == 0 && rear == capacity - 1)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }

    //    public bool IsEmpty()
    //    {
    //        if (front == -1)
    //            return true;
    //        else
    //            return false;
    //    }

    //    public void PrintQueue()
    //    {
    //        for (int i = front; i <= rear; i++)
    //        {
    //            Console.Write(arr[i] + " ");
    //        }

    //        Console.WriteLine();
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Queue queue = new Queue(5);

    //        queue.DeQueue();

    //        queue.EnQueue(1);
    //        queue.EnQueue(2);
    //        queue.EnQueue(3);
    //        queue.EnQueue(4);
    //        queue.EnQueue(5);
    //        queue.EnQueue(6);

    //        queue.PrintQueue();

    //        queue.DeQueue();
    //        Console.WriteLine("Before dequeueing...");
    //        queue.PrintQueue();
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region GeeksForGeeks
    #region Array Representation of Queen

    public class Queue
    {
        public int front, rear, max;
        public int[] ele;

        public Queue(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        // Enqueue() operation in Queue adds an element to the end of the queue
        public void Enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                ele[++rear] = item;
            }
        }

        // Dequeue(): Removes the first element from the queue
        public int Dequeue()
        {
            if(front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine(ele[front] + " dequeued from queue");
                int p = ele[front++];
                Console.WriteLine($"Front item is {ele[front]}");
                Console.WriteLine($"Rear item is {ele[rear]}");

                return p;
            }
        }

        public void PrintQueue()
        {
            if(front == rear + 1)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                for(int i = front;i <= rear;i++)
                {
                    Console.WriteLine(ele[i] + " enqueued to queue");
                }
            }
        }
    }


    #endregion

    class MainClass
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(5);

            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            queue.PrintQueue();

            queue.Dequeue();
            queue.Dequeue();

            queue.PrintQueue();
        }
    }
    #endregion


    #region Non-Generic Queue in C#
    #region Creating and adding
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Creating a queue collection
    //        Queue queue = new Queue();

    //        // Adding item to the queue using the Enqueue method
    //        queue.Enqueue(101);
    //        queue.Enqueue("Hello");
    //        queue.Enqueue(3.14f);
    //        queue.Enqueue(true);
    //        queue.Enqueue(67.8);
    //        queue.Enqueue('A');

    //        // Printing the queue items using foreach loop
    //        foreach (var item in queue)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Removing and peeking
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Creating a queue collection
    //        Queue queue = new Queue();

    //        // Adding item to the queue using the Enqueue method
    //        queue.Enqueue(101);
    //        queue.Enqueue("Hello");
    //        queue.Enqueue(3.14f);
    //        queue.Enqueue(true);
    //        queue.Enqueue(67.8);
    //        queue.Enqueue('A');

    //        // Printing the queue items using foreach loop
    //        Console.WriteLine($"All queue Elements: {queue.Count}");
    //        foreach (var item in queue)
    //        {
    //            Console.Write(item + " ");
    //        }

    //        // Removing and Returning a item from the queue using the Dequeue method
    //        Console.WriteLine($"\n\nDeleted element: {queue.Dequeue()}");

    //        Console.WriteLine($"All Queue Elements After Deletion: Count {queue.Count}");
    //        foreach (var item in queue)
    //        {
    //            Console.Write($"{item} ");
    //        }

    //        // Fetch the topmost element from Queue Using Peek method
    //        Console.WriteLine($"\n\nFirst Element of Queue is: {queue.Peek()}");
    //        Console.WriteLine($"Total Elements present in Queue : {queue.Count}");

    //        //Printing Items After Clearing the Queue
    //        queue.Clear();
    //        Console.WriteLine($"\nQueue Elements After Clear Operation: Count {queue.Count}");
    //        foreach (var item in queue)
    //        {
    //            Console.Write($"{item} ");
    //        }

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Check Whether an Element Exists or not
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Creating a Queue collection
    //        Queue queue = new Queue();

    //        //Adding item to the queue using the Enqueue method
    //        queue.Enqueue(101);
    //        queue.Enqueue("Hello");
    //        queue.Enqueue(3.14f);
    //        queue.Enqueue(true);
    //        queue.Enqueue(67.8);
    //        queue.Enqueue('A');

    //        Console.WriteLine("All Elements of Queue");
    //        foreach (var item in queue)
    //        {
    //            Console.Write($"{item} ");
    //        }

    //        Console.WriteLine("\n\nChecking if the element Hello is present in the queue or not");
    //        // Checking if the element Hello is present in the Stack or not

    //        if (queue.Contains("Hello"))
    //        {
    //            Console.WriteLine("Element Hello is found");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Element Hello is not found");
    //        }

    //        if (queue.Contains("World"))
    //        {
    //            Console.WriteLine("Element World is found");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Element World is not found");
    //        }
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Cloning
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Creating a queue collection
    //        Queue queue = new Queue();

    //        //Adding item to the queue using the Enqueue method
    //        queue.Enqueue(101);
    //        queue.Enqueue("Hello");
    //        queue.Enqueue(3.14f);
    //        queue.Enqueue(true);
    //        queue.Enqueue(67.8);

    //        //Printing All Queue Elements using For Each Loop
    //        Console.WriteLine("Queue Elements:");
    //        foreach (var item in queue)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        //Creating a clone queue using Clone method
    //        Queue cloneQueue = (Queue)queue.Clone();
    //        Console.WriteLine("\nCloned Queue Elements:");
    //        foreach (var item in cloneQueue)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region How to copy a queue to an existing array
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Creating a queue collection
    //        Queue queue = new Queue();

    //        //Adding item to the queue using the Enqueue method
    //        queue.Enqueue(101);
    //        queue.Enqueue("Hello");
    //        queue.Enqueue(3.14f);
    //        queue.Enqueue(true);
    //        queue.Enqueue(67.8);

    //        //Printing All Queue Elements using For Each Loop
    //        Console.WriteLine("Queue Elements:");
    //        foreach (var item in queue)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        //Copying the queue to an object array
    //        object[] queueCopy = new object[5];
    //        queue.CopyTo(queueCopy, 0);
    //        Console.WriteLine("\nQueue Copy Array Elements:");
    //        foreach (var item in queueCopy)
    //        {
    //            Console.Write(item + " ");
    //        }

    //        Console.ReadKey();
    //    }
    //}
    #endregion
    #endregion

    #region Generic Queue Collection Class

    #region Basically
    //public class Program
    //{
    //    public static void Main()
    //    {
    //        //Creating a Queue to Store Integer Values
    //        Queue<int> queue = new Queue<int>();

    //        //Adding Elements to the Queue using Enqueue Method
    //        queue.Enqueue(10);
    //        queue.Enqueue(20);
    //        queue.Enqueue(30);
    //        //Adding Duplicate
    //        queue.Enqueue(30);

    //        //As int is not a Reference type so null can not be accepted by this queue
    //        //queue.Enqueue(null); //Compile-Time Error
    //        //As the queue is integer type, so string values can not be accepted
    //        //queue.Enqueue("Hell0"); //Compile-Time Error

    //        //Accesing all the Elements of the Queue using For Each Loop
    //        Console.WriteLine("Generic Queue Elements");
    //        foreach (int item in queue)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Complex Types
    //public class Employee
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //    public int Salary { get; set; }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Create Employee object
    //        Employee emp1 = new Employee()
    //        {
    //            ID = 101,
    //            Name = "Pranaya",
    //            Gender = "Male",
    //            Salary = 20000
    //        };
    //        Employee emp2 = new Employee()
    //        {
    //            ID = 102,
    //            Name = "Priyanka",
    //            Gender = "Female",
    //            Salary = 30000
    //        };
    //        Employee emp3 = new Employee()
    //        {
    //            ID = 103,
    //            Name = "Anurag",
    //            Gender = "Male",
    //            Salary = 40000
    //        };
    //        Employee emp4 = new Employee()
    //        {
    //            ID = 104,
    //            Name = "Sambit",
    //            Gender = "Female",
    //            Salary = 40000
    //        };
    //        Employee emp5 = new Employee()
    //        {
    //            ID = 105,
    //            Name = "Preety",
    //            Gender = "Female",
    //            Salary = 50000
    //        };

    //        // Create a Generic Queue of Employees
    //        Queue<Employee> queueEmployees = new Queue<Employee>();

    //        // To add an item into the queue, use the Enqueue() method.
    //        // emp1 is added first, so this employee, will be the first to get out of the queue
    //        queueEmployees.Enqueue(emp1);

    //        // emp2 will be queued up next, so employee 2 will be second to get out of the queue
    //        queueEmployees.Enqueue(emp2);

    //        // emp3 will be queued up next, so employee 3 will be third to get out of the queue
    //        queueEmployees.Enqueue(emp3);

    //        // emp3 will be queued up next, so employee 4 will be fourth to get out of the queue
    //        queueEmployees.Enqueue(emp4);

    //        // emp5 will be queued up next, so employee 5 will be fifth to get out of the queue
    //        queueEmployees.Enqueue(emp5);

    //        // If you need to loop thru each items in the queue, then we can use the foreach loop 
    //        // in the same way as we use it with other collection classes. 
    //        // The foreach loop will only iterate thru the items in the queue, but will not remove them. 
    //        // Notice that the items from the queue are retrieved in FIFI (First In First Out), order. 
    //        // The First element added to the queue is the first one to be removed.
    //        Console.WriteLine("Retrive Using Foreach Loop");
    //        foreach (Employee emp in queueEmployees)
    //        {
    //            Console.WriteLine(emp.ID + " - " + emp.Name + " - " + emp.Gender + " - " + emp.Salary);
    //            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);
    //        }
    //        Console.WriteLine("------------------------------");

    //        // To retrieve an item from the queue, use the Dequeue() method. 
    //        // Notice that the items are dequeued in the same order in which they were enqueued.
    //        // Dequeue() method removes and returns the item at the beginning of the Queue.
    //        // Since emp1 object is the one that is enqueued onto the queue first, this object will be
    //        // first to be dequeued and returned from the queue by using Dequeue() method

    //        Console.WriteLine("Retrive Using Dequeue Method");
    //        Employee e1 = queueEmployees.Dequeue();
    //        Console.WriteLine(e1.ID + " - " + e1.Name + " - " + e1.Gender + " - " + e1.Salary);
    //        Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);

    //        Employee e2 = queueEmployees.Dequeue();
    //        Console.WriteLine(e2.ID + " - " + e2.Name + " - " + e2.Gender + " - " + e2.Salary);
    //        Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);

    //        Employee e3 = queueEmployees.Dequeue();
    //        Console.WriteLine(e3.ID + " - " + e3.Name + " - " + e3.Gender + " - " + e3.Salary);
    //        Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);

    //        Employee e4 = queueEmployees.Dequeue();
    //        Console.WriteLine(e4.ID + " - " + e4.Name + " - " + e4.Gender + " - " + e4.Salary);
    //        Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);

    //        Employee e5 = queueEmployees.Dequeue();
    //        Console.WriteLine(e5.ID + " - " + e5.Name + " - " + e5.Gender + " - " + e5.Salary);
    //        Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);
    //        Console.WriteLine("------------------------------");

    //        // Now there will be no items left in the queue. 
    //        // So, let's Enqueue the five objects once again
    //        queueEmployees.Enqueue(emp1);
    //        queueEmployees.Enqueue(emp2);
    //        queueEmployees.Enqueue(emp3);
    //        queueEmployees.Enqueue(emp4);
    //        queueEmployees.Enqueue(emp5);

    //        // To retrieve an item that is present at the beginning of the queue,
    //        // without removing it, then use the Peek() method.

    //        Console.WriteLine("Retrive Using Peek Method");
    //        Employee e101 = queueEmployees.Peek();
    //        Console.WriteLine(e101.ID + " - " + e101.Name + " - " + e101.Gender + " - " + e101.Salary);
    //        Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);

    //        Employee e103 = queueEmployees.Peek();
    //        Console.WriteLine(e103.ID + " - " + e103.Name + " - " + e103.Gender + " - " + e103.Salary);
    //        Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);

    //        Console.WriteLine("------------------------------");

    //        // To check if an item exists in the stack, use Contains() method.
    //        if (queueEmployees.Contains(emp3))
    //        {
    //            Console.WriteLine("Emp3 is in Queue");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Emp3 is not in queue");
    //        }

    //        Console.ReadKey();
    //    }
    //}
    #endregion
    #endregion

    #region ConcurrentQueue<T> Collection Class
    #region Single thread
    //class Program
    //{
    //    static void Main()
    //    {
    //        TestQueue();
    //        Console.ReadKey();
    //    }

    //    public static void TestQueue()
    //    {
    //        var MobileOrders = new Queue<string>();
    //        GetOrders("Pranaya", MobileOrders);
    //        GetOrders("Anurag", MobileOrders);

    //        foreach (var mobileOrder in MobileOrders)
    //        {
    //            Console.WriteLine($"Order: {mobileOrder}");
    //        }
    //    }

    //    private static void GetOrders(string custName, Queue<string> MobileOrders)
    //    {
    //        for (int i = 0; i < 3; i++)
    //        {
    //            Thread.Sleep(100);
    //            string order = string.Format($"{custName} Needs {i + 3} Mobiles");
    //            MobileOrders.Enqueue(order);
    //        }
    //    }
    //}
    #endregion

    #region Multiple threads
    //class Program
    //{
    //    static object lockObj = new object();

    //    static void Main()
    //    {
    //        TestQueue();
    //        Console.ReadKey();
    //    }

    //    public static void TestQueue()
    //    {
    //        var MobileOrders = new Queue<string>();
    //        Task t1 = Task.Run(() => GetOrders("Pranaya", MobileOrders));
    //        Task t2 = Task.Run(() => GetOrders("Anurag", MobileOrders));
    //        Task.WaitAll(t1, t2); //Wait till both the task completed

    //        foreach (var mobileOrder in MobileOrders)
    //        {
    //            Console.WriteLine($"Order: {mobileOrder}");
    //        }
    //    }

    //    private static void GetOrders(string custName, Queue<string> MobileOrders)
    //    {
    //        for (int i = 0; i < 100; i++)
    //        {
    //            //Thread.Sleep(100);
    //            string order = string.Format($"{custName} Needs {i + 3} Mobiles");
    //            lock(lockObj)
    //            {
    //                MobileOrders.Enqueue(order);
    //            }
    //        }
    //    }
    //}
    #endregion

    #region ConcurrentQueue with more than one Thread
    //class Program
    //{
    //    static void Main()
    //    {
    //        TestQueue();
    //        Console.ReadKey();
    //    }

    //    public static void TestQueue()
    //    {
    //        var MobileOrders = new ConcurrentQueue<string>();
    //        Task t1 = Task.Run(() => GetOrders("Pranaya", MobileOrders));
    //        Task t2 = Task.Run(() => GetOrders("Anurag", MobileOrders));
    //        Task.WaitAll(t1, t2); //Wait till both the task completed

    //        foreach (var mobileOrder in MobileOrders)
    //        {
    //            Console.WriteLine($"Order: {mobileOrder}");
    //        }
    //    }

    //    private static void GetOrders(string custName, ConcurrentQueue<string> MobileOrders)
    //    {
    //        for (int i = 0; i < 3; i++)
    //        {
    //            Thread.Sleep(5000);
    //            string order = string.Format($"{custName} Needs {i + 3} Mobiles");
    //            MobileOrders.Enqueue(order);
    //        }
    //    }
    //}
    #endregion

    #region Remove Elements from ConcurrentQueue<T> Collection
    //class Program
    //{
    //    static void Main()
    //    {
    //        //Creating a ConcurrentQueue to Store Integer Values
    //        ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();

    //        //Adding Elements to ConcurrentQueue using Enqueue Method
    //        concurrentQueue.Enqueue(10);
    //        concurrentQueue.Enqueue(20);
    //        concurrentQueue.Enqueue(30);
    //        concurrentQueue.Enqueue(40);

    //        Console.WriteLine("All Concurrent Queue Elements Before Removing");
    //        foreach (var item in concurrentQueue)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        // Removing and Returning the First Element from ConcurrentQueue using TryDequeue method
    //        bool IsRemoved = concurrentQueue.TryDequeue(out int result);
    //        Console.WriteLine($"\nTryDequeue Return : {IsRemoved}");
    //        Console.WriteLine($"TryDequeue Result Value : {result}");

    //        //Printing Elements After Removing the First Element
    //        Console.WriteLine("All Concurrent Queue Elements After Removing");
    //        foreach (var item in concurrentQueue)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        // Removing and Returning the First Element from ConcurrentQueue using TryDequeue method
    //        bool IsPeeked = concurrentQueue.TryPeek(out int Result2);
    //        Console.WriteLine($"\nTryPeek Return : {IsPeeked}");
    //        Console.WriteLine($"TryPeek Result Value : {Result2}");

    //        //Printing Elements After Peek the First Element
    //        Console.WriteLine("All Concurrent Queue Elements After TryPeek");
    //        foreach (var element in concurrentQueue)
    //        {
    //            Console.WriteLine($"{element} ");
    //        }

    //        Console.ReadKey();
    //    }
    //}
    #endregion
    #endregion

    #region First non-repeating character in a stream
    //public class Solution
    //{
    //    public string FirstNonRepeating(string a)
    //    {
    //        int[] charCount = new int[26];
    //        char[] charOrder = new char[a.Length];
    //        string result = "";

    //        for (int i = 0; i < a.Length; i++)
    //        {
    //            char currentChar = a[i];
    //            int index = currentChar - 'a';

    //            // Update the count of the character
    //            charCount[index]++;

    //            // Update the order array
    //            charOrder[i] = currentChar;

    //            // Find the first non-repeating character
    //            char firstNonRepeating = '#';
    //            for (int j = 0; j <= i; j++)
    //            {
    //                if (charCount[charOrder[j] - 'a'] == 1)
    //                {
    //                    firstNonRepeating = charOrder[j];
    //                    break;

    //                }
    //            }

    //            result += firstNonRepeating;
    //        }

    //        return result;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();
    //        string s = "abcde";

    //        string result = solution.FirstNonRepeating(s);

    //        Console.WriteLine(result);
    //    }
    //}
    #endregion
}