using System.Collections;

namespace DSA
{
    class SimpleList : IList
    {
        private object[] contents = new object[8];
        private int count;

        public SimpleList()
        {
            count = 0;
        }

        // IList members
        public int Add(object value)
        {
            if (count < contents.Length)
            {
                contents[count] = value;
                count++;

                return (count - 1);
            }

            return -1;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(object value)
        {
            for (int i = 0; i < count; i++)
            {
                if (contents[i] == value) return true;
            }
            return false;
        }

        public int IndexOf(object value)
        {
            for (int i = 0; i < count; i++)
            {
                if (contents[i] == value) return i;
            }
            return -1;
        }

        public void Insert(int index, object value)
        {
            if ((count + 1 <= contents.Length) && (index < count) && (index >= 0))
            {
                count++;

                for (int i = count - 1; i > index; i--)
                    contents[i] = contents[i - 1];
                contents[index] = value;
            }
        }

        public bool IsFixedSize
        {
            get { return true; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < count))
            {
                for (int i = index; i < count - 1; i++)
                    contents[i] = contents[i + 1];

                count--;
            }
        }

        public object this[int index]
        {
            get { return contents[index]; }
            set { contents[index] = value; }
        }

        // ICollection members
        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < count; i++)
                array.SetValue(contents[i], index++);
        }

        public int Count
        {
            get { return count; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        // Return the current instance since the underlying store is not publicly available.
        public object SyncRoot
        {
            get { return this; }
        }

        // IEnumrable members
        public IEnumerator GetEnumerator()
        {
            // Refer to the IEnumrator documentation for an example of implementing an enumerator.
            throw new NotImplementedException("The method or operation is not implemented.");
        }

        public void PrintContents()
        {
            Console.WriteLine($"List has a capacity of {contents.Length} and currently has {count} elements.");
            Console.Write("List contents:");
            for (int i = 0; i < Count; i++)
            {
                Console.Write($" {contents[i]}");
            }
            Console.WriteLine();
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            var test = new SimpleList();

            // Populate the List.
            Console.WriteLine("Populate the List");
            test.Add("one");
            test.Add("two");
            test.Add("three");
            test.Add("four");
            test.Add("five");
            test.Add("six");
            test.Add("seven");
            test.Add("eight");
            test.PrintContents();
            Console.WriteLine();

            // Remove elements from the list.
            Console.WriteLine("Remove elements from the list");
            test.Remove("six");
            test.Remove("eight");
            test.PrintContents();
            Console.WriteLine();

            // Add an element to the end of the list.
            Console.WriteLine("Add an element to the end of the list");
            test.Add("nine");
            test.PrintContents();
            Console.WriteLine();

            // Insert an element into the middle of the list.
            Console.WriteLine("Insert an element into the middle of the list");
            test.Insert(4, "number");
            test.PrintContents();
            Console.WriteLine();

            // Check for specific elements in the list.
            Console.WriteLine("Check for specific elements in the list");
            Console.WriteLine($"List contains \"three\": {test.Contains("three")}");
            Console.WriteLine($"List contains \"ten\": {test.Contains("ten")}");
        }
    }
}