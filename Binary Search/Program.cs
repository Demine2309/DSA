namespace DSA
{
    #region Binary Search
    //public class Solution
    //{
    //    public int BinarySearch(int[] arr, int low, int high, int key)
    //    {
    //        while (low <= high)
    //        {
    //            int mid = (low + high) / 2;

    //            if (arr[mid] < key)
    //                low = mid + 1;
    //            else if (arr[mid] > key)
    //                high = mid - 1;
    //            else
    //                return mid;
    //        }

    //        return -1;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] arr = { 7, 31, 5, 2, 3, 54, 23, 6, 1, 0, 4, 8 };

    //        Console.WriteLine("Array before sort:");
    //        foreach (int i in arr) Console.Write(i + " ");
    //        Console.WriteLine();

    //        Console.WriteLine("Array after sort:");
    //        Array.Sort(arr);
    //        foreach (int i in arr) Console.Write(i + " ");
    //        Console.WriteLine();

    //        int target = 8;
    //        Console.WriteLine("The position of target...");
    //        Console.WriteLine(solution.BinarySearch(arr, 0, arr.Length - 1, target) + 1);
    //    }
    //}
    #endregion

    #region Binary search tree
    public class Node
    {
        public int _data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            _data = data;
            left = null;
            right = null;
        }
    }

    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int data)
        {
            root = InsertRecursive(root, data);
        }

        private Node InsertRecursive(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            if (data < root._data)
            {
                root.left = InsertRecursive(root.left, data);
            }
            else if (data > root._data)
            {
                root.right = InsertRecursive(root.right, data);
            }

            return root;
        }

        public Node FindNodeIterative(int item)
        {
            Node node = root;

            // Loop untill we descend past the closest leaf node
            while (node != null)
            {
                if (item == node._data)
                {
                    return node;
                }
                else if (item < node._data)
                {
                    node = node.left;
                }
                else if (item > node._data)
                {
                    node = node.right;
                }
            }

            // Not found
            return null;
        }

        public void InorderTraversal()
        {
            InorderRecursive(root);
        }

        private void InorderRecursive(Node root)
        {
            if(root != null)
            {
                InorderRecursive(root.left);
                Console.WriteLine(root._data + " ");
                InorderRecursive(root.right);
            }
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(60);
            bst.Insert(30);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(70);
            bst.Insert(60);
            bst.Insert(80);

            Console.WriteLine("Inorder Traversal of the BST:");
            bst.InorderTraversal();
            Console.WriteLine();

            int searchKey = 54;
            Node foundNode = bst.FindNodeIterative(searchKey);
            if (foundNode != null)
            {
                Console.WriteLine($"Node with data {searchKey} found in the BST.");
            }
            else
            {
                Console.WriteLine($"Node with data {searchKey} not found in the BST.");
            }
        }
    }
    #endregion
}