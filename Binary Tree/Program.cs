namespace DSA
{
    //public class Node
    //{
    //    public int key;
    //    public Node left, right;

    //    public Node(int item)
    //    {
    //        key = item;
    //        left = right = null;
    //    }
    //}

    //public class BinaryTree
    //{
    //    // Root of Binary tree
    //    Node root;

    //    // Contructors
    //    BinaryTree(int key) { root = new Node(key); }

    //    BinaryTree() { root = null; }

    //    // Driver code
    //    public static void Main(string[] args)
    //    {
    //        BinaryTree tree = new BinaryTree();

    //        tree.root = new Node(1);
    //        /* Following is the tree after above statement
    //                 1
    //                / \
    //             null null */
    //        tree.root.left = new Node(2);
    //        tree.root.right = new Node(3);
    //        /* 2 and 3 become left and right children of 1
    //                 1
    //                / \
    //               2   3
    //              / \ / \
    //        null null null null */
    //        tree.root.left.left = new Node(4);
    //        /* 4 becomes left child of 2
    //                       1
    //                      / \
    //                  2        3
    //                 / \      / \
    //                4 null null null
    //              / \
    //           null null 
    //        */
    //    }
    //}

    #region Array implementation
    public class Tree
    {
        static void Main(string[] args)
        {
            ArrayImp obj  = new ArrayImp();

            obj.Root("A");
            obj.SetLeft("B", 0);
            obj.SetRight("C", 0);
            obj.SetLeft("D", 1);
            obj.SetRight("E", 1);
            obj.SetRight("F", 2);
            obj.PrintTree();
        }
    }

    class ArrayImp
    {
        static int root = 0;
        static string[] str = new string[10];

        public void Root(String key)
        {
            str[0] = key;
        }

        public void SetLeft(String key, int root)
        {
            int t = (root * 2) + 1;

            if (str[root]  == null)
            {
                Console.WriteLine($"Can't set child at {t}, no parrent found\n");
            }
            else
            {
                str[t] = key;
            }
        }

        public void SetRight(string key, int root)
        {
            int t = (root * 2) + 2;

            if (str[root] == null)
            {
                Console.Write("Can't set child at {0}, no parent found\n", t);
            }
            else
            {
                str[t] = key;
            }
        }

        public void PrintTree()
        {
            for(int i = 0; i< 10; i++)
            {
                if (str[i] != null)
                    Console.Write(str[i]);
                else
                    Console.Write("-");
            }
        }
    }
    #endregion
}