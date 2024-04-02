using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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
    //public class Tree
    //{
    //    static void Main(string[] args)
    //    {
    //        ArrayImp obj  = new ArrayImp();

    //        obj.Root("A");
    //        obj.SetLeft("B", 0);
    //        obj.SetRight("C", 0);
    //        obj.SetLeft("D", 1);
    //        obj.SetRight("E", 1);
    //        obj.SetRight("F", 2);
    //        obj.PrintTree();
    //    }
    //}

    //class ArrayImp
    //{
    //    static int root = 0;
    //    static string[] str = new string[10];

    //    public void Root(String key)
    //    {
    //        str[0] = key;
    //    }

    //    public void SetLeft(String key, int root)
    //    {
    //        int t = (root * 2) + 1;

    //        if (str[root]  == null)
    //        {
    //            Console.WriteLine($"Can't set child at {t}, no parrent found\n");
    //        }
    //        else
    //        {
    //            str[t] = key;
    //        }
    //    }

    //    public void SetRight(string key, int root)
    //    {
    //        int t = (root * 2) + 2;

    //        if (str[root] == null)
    //        {
    //            Console.Write("Can't set child at {0}, no parent found\n", t);
    //        }
    //        else
    //        {
    //            str[t] = key;
    //        }
    //    }

    //    public void PrintTree()
    //    {
    //        for(int i = 0; i< 10; i++)
    //        {
    //            if (str[i] != null)
    //                Console.Write(str[i]);
    //            else
    //                Console.Write("-");
    //        }
    //    }
    //}
    #endregion

    #region Find the Maximum Depth or Height of given Binary Tree (Recursive)
    //public class Node
    //{
    //    public int data;
    //    public Node left, right;

    //    public Node(int item)
    //    {
    //        data = item;
    //        left = right = null;
    //    }
    //}

    //public class BinaryTree
    //{
    //    public Node root;

    //    // Computer the "maxDepth" of a tree -- the number of nodes along the longest path from the 
    //    // root node down to the farthest leaf node
    //    public int MaxDepth(Node node)
    //    {
    //        if (node == null)
    //            return 0;
    //        else
    //        {
    //            int leftDepth = MaxDepth(node.left);
    //            int rightDepth = MaxDepth(node.right);  

    //            if(leftDepth > rightDepth)
    //                return (leftDepth + 1);
    //            else
    //                return (rightDepth + 1);
    //        }
    //    }


    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        BinaryTree tree = new BinaryTree();

    //        tree.root = new Node(1);
    //        tree.root.left = new Node(2);
    //        tree.root.right = new Node(3);
    //        tree.root.left.left = new Node(4);
    //        tree.root.left.right = new Node(5);

    //        Console.WriteLine($"Height of tree is {tree.MaxDepth(tree.root)}");
    //    }
    //}
    #endregion

    #region Find the Maximum Depthor Height of a tree using Level Order Traversal
    //public class Node
    //{
    //    public int data;
    //    public Node left, right;

    //    public Node(int item)
    //    {
    //        data = item;
    //        left = right = null;
    //    }
    //}

    //public class BinaryTree
    //{
    //    public Node root;

    //    public int Height()
    //    {
    //        int depth = 0;

    //        Queue<Node> queue = new Queue<Node>();

    //        queue.Enqueue(root);
    //        queue.Enqueue(null);

    //        while(queue.Count != 0)
    //        {
    //            Node temp = queue.Dequeue();

    //            if (temp == null)
    //                depth++;

    //            if (temp != null)
    //            {
    //                if (temp.left != null)
    //                    queue.Enqueue(temp.left);
    //                if (temp.right != null)
    //                    queue.Enqueue(temp.right);
    //            }
    //            else if (queue.Count != 0)
    //                queue.Enqueue(null);
    //        }

    //        return depth;   
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        BinaryTree tree = new BinaryTree();

    //        tree.root = new Node(1);
    //        tree.root.left = new Node(2);
    //        tree.root.right = new Node(3);
    //        tree.root.left.left = new Node(4);
    //        tree.root.left.right = new Node(5);

    //        Console.WriteLine("Height(Depth) of tree is: " + tree.Height());
    //    }
    //}
    #endregion

    #region Insertion in a Binary Tree is level order
    //public class Node
    //{
    //    public int data;
    //    public Node left, right;

    //    public Node(int item)
    //    {
    //        data = item;
    //        left = right = null;
    //    }
    //}

    //public class BinaryTree
    //{
    //    public Node root;

    //    public void Inorder(Node temp)
    //    {
    //        if(temp == null)
    //            return;

    //        Inorder(temp.left);
    //        Console.Write(temp.data + " ");
    //        Inorder(temp.right);    
    //    }

    //    public void Insert(Node temp, int data)
    //    {
    //        if(temp == null)
    //        {
    //            root = new Node(data);
    //            return;
    //        }

    //        Queue<Node> queue = new Queue<Node>();  

    //        queue.Enqueue(temp);

    //        while (queue.Count != 0)
    //        {
    //            temp = queue.Peek();
    //            queue.Dequeue();

    //            if (temp.left == null)
    //            {
    //                temp.left = new Node(data);
    //                break;
    //            }
    //            else
    //                queue.Enqueue(temp.left);

    //            if(temp.right == null)
    //            {
    //                temp.right = new Node(data);
    //                break;
    //            }
    //            else
    //                queue.Enqueue(temp.right);
    //        }
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        BinaryTree tree = new BinaryTree();

    //        tree.root = new Node(10);
    //        tree.root.left = new Node(11);
    //        tree.root.left.left = new Node(7);
    //        tree.root.right = new Node(9);
    //        tree.root.right.left = new Node(15);
    //        tree.root.right.right = new Node(8);

    //        Console.WriteLine("Inoder traversal before insertion:");
    //        tree.Inorder(tree.root);

    //        int data = 12;
    //        tree.Insert(tree.root, data);

    //        Console.WriteLine("Inorder traversal after insertion");
    //        tree.Inorder(tree.root);
    //    }
    //}
    #endregion

    #region Deletion in a Binary Tree
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        public Node root;

        public void Inorder(Node temp)
        {
            if(temp == null)
                return;

            Inorder(temp.left);
            Console.Write(temp.data + " ");
            Inorder(temp.right);
        }

        // Function to delete deepest element in Binary Tree
        private void DeleteDeepest(Node root, Node delNode)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            Node temp = null;

            while(queue.Count != 0)
            {
                temp = queue.Peek();
                queue.Dequeue();

                if(temp == delNode)
                {
                    temp = null;
                    return;
                }
                if(temp.right != null)
                {
                    if (temp.right == delNode)
                    {
                        temp.right = null;
                        return;
                    }
                    else
                        queue.Enqueue(temp.right);
                }
                if (temp.left != null)
                {
                    if (temp.left == delNode)
                    {
                        temp.left = null;
                        return;
                    }
                    else
                        queue.Enqueue(temp.left);
                }
            }
        }

        public void Delete(Node root, int key)
        {
            if (root == null)
                return;

            if (root.left == null && root.right == null)
            {
                if (root.data == key)
                {
                    root = null;
                    return;
                }
                else
                    return;
            }

            Queue<Node> queue = new Queue<Node>();  
            queue.Enqueue(root);

            Node temp = null, keyNode = null;

            while(queue.Count != 0)
            {
                temp = queue.Peek();
                queue.Dequeue();

                if(temp.data == key) 
                    keyNode = temp;
                
                if(temp.left != null)
                    queue.Enqueue(temp.left);   
                
                if(temp.right != null)
                    queue.Enqueue(temp.right);
            }

            if(keyNode != null)
            {
                int x = temp.data;
                keyNode.data = x;
                DeleteDeepest(root, temp);
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.root = new Node(10);
            tree.root.left = new Node(11);
            tree.root.left.left = new Node(7);
            tree.root.left.right = new Node(12);
            tree.root.right = new Node(9);
            tree.root.right.left = new Node(15);
            tree.root.right.right = new Node(8);

            Console.Write("Inorder traversal "
                          + "before deletion: ");
            tree.Inorder(tree.root);

            int key = 11;
            tree.Delete(tree.root, key);

            Console.Write("\nInorder traversal "
                          + "after deletion: ");
            tree.Inorder(tree.root);
        }
    }
    #endregion
}