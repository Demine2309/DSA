using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace DSA
{
    #region Learn Data structure & Algorithm with William Fiset (Theory)
    /*
	 * 1. Binary search Tree introduction
	 * * Quick terminology crash course
	 * - A tree is an undirected graph which satisfies any of the following definitions:
	 *		+ An acyclic connnected graph
	 *		+ A connected graph with N nodes and N-1 edges
	 *		+ An graph in which any two vertices are connected by exactly one path
	 * - If we have a rooted tree then we will want to have a reference to the root node of our tree.
	 * - It does not always matter which node is selected to be the root node because any does can root the tree!
	 * - A child is a node extending from another node. A parent is the inverse of this
	 * - A leaf node í a node with no children.
	 * * Which is a Binary Tree (BT)
	 * - A binary tree us a tree for which every node has at most two child nodes.
	 * * Which is a Binary Seach Tree (BST)?
	 * - A binary search tree is a binary tree that satisfies the BST invariant: left subtree has smaller elements and
	 *	 right subtree has large elements.
	 * - BST operations allow for duplicate values, but most of the time we are only interested in having unique elements 
	 *	 inside our tree.
	 * * When and Where are Binary Trees used?
	 * - Binary Search Trees (BSTs)
	 *		+ Implementation of some map and sets ADTs
	 *		+ Red Black Trees
	 *		+ AVL Trees
	 *		+ Splay Trees
	 *		+ etc...
	 * - Used in the implementation of binary heaps
	 * - Syntax trees (used by compiler and calculators)
	 * - Treap - a probabilistic DS (uses a randomized BST)
	 * 2. Inserting elements into a Binary Search Tree (BST)
	 * * Adding elements to a BST
	 * - Binary Search Tree (BST) elements must be comparable so that we can order then inside the tree
	 * - When inserting an element we want to compare its value to the value stored in the current node we're considering 
	 *   to decide on one of the following:
	 *		+ Recurse down left subtree        (< case)
	 *		+ Recurse down right subtree       (> case)
	 *		+ Handle finding a duplicate value (= case)
	 *		+ Create a new node                (found a null leaf)
	 * - On average the insertion time will be logarithmic, but in the worst case this could degrade to linear time.
	 * 3. Removing elements from a Binary Search Tree (BST)
	 * - Removing elements from a BST can be seen as a two steps process:
	 *		+) Find the element we wish to remove (if its exists)
	 *		+) Replace the node we want to remove with its successor (if any) to maintain the BST invariant.
	 * * Find phase
	 * - When searching our BST for a node with a particular value one of four things will happen:
	 *		+) We hit a null node at which point we know the value does not exist whithin our BST
	 *		+) Comparator value equal to 0 (found it!)
	 *		+) Comparator value less than to 0 (the value, if it exists, is in the left subtree)
	 *		+) Comaprator value greater than to 0 (the value, if it exists, is in the right subtree)
	 *	* Remove phase
	 *	- Case I: leaf node
	 *		+ If the node we wish to remove is a leaf node then we may do so without side effect
	 *	- Cases II & III: either the left/right child node is a subtree
	 *		+ The successor of the node we are trying to remove in these cases will be the root node of the left/right subtree
	 *		+ It maybe the case that you are removing the root node of the BST in which case its immediate child becomes the
	 *		  new root as you would expect.
	 *	- Case IV: Node to remove has both a left subtree and a right subtree
	 *		+) Question: In which subtree will the successor of the node we are trying to remove be?
	 *		+) Answer: The answer is both! The successor can either be the largest value in the left subtree or the smallest value
	 *		   right subtree.
	 *		+) A justification for why there could be more than one successor is:
	 *			> The largest value in the left Subtree satifies the BST invariant since it:
	 *			1. Is larger than everything in left subtree. This follows inmmediately from the definition of being the largest
	 *			2. Is smaller than everything in right subtree because it was found in the left subtree
	 *			> The smallest value in the right subtree satifies the BST invariant since it:
	 *			1. Is smaller than everything is right subtree. This follows immediately from the definition of being the smallest
	 *			2. Is large than everything in left subtree because it was found in the right subtree.
	 * 4. Tree traversals (Preorder, Inorder, Postorder & Level order)
	 * * Preorder traversal
	 * - Preorder prints before the recursive calls
	 * - Print the value of the current node them traverse the left subtree followed by the right subtree
	 * * Inorder traversal
	 * - Inorder prints between the recursive calls
	 * - Traverse the left subtree, then print the value of the node and continue traversing the right subtree
	 * - Notice that with a BST the value printed by the inorder traversal are in increasing order!
	 * + Postorder Traversal
	 * - Postorder prints after the recursive calls
	 * - Traverse the left subtree followed by the right subtree then print the value of the node
	 * * Level order traversal
	 * - In a level order traversal we want to print the nodes as they appear one layer at a time
	 * - To obtain this ordering we want to do a Breadth First Search (BFS) from the root node down to the leaf nodes
	 * - To do a BFS we will need to maintain a Queue of the nodes left to explore
	 * - Begin with the root inside of the queue and finish when the queue is empty
	 * - At each iteration we add the left child and then the right child of the current node to out Queue.
	 */
    #endregion

    #region Learn Data structure & Algorithm with William Fiset (Code)
    public class BinarySearchTree
    {
        // Tracks the number of nodes in this BST
        private int nodeCount = 0;

        // This BST is a rooted tree so we maintain a handle on the root node
        private TreeNode root = null;


        // Internal node containing node references
        // and the actual node data
        private class TreeNode
        {
            public int data;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(TreeNode left, TreeNode right, int value)
            {
                this.data = value;
                this.left = left;
                this.right = right;
            }
        }

        // Check if this binary tree is empty
        public bool IsEmpty()
        {
            return Size() == 0;
        }

        // Get the number of nodes in this binay tree
        public int Size()
        {
            return nodeCount;
        }

        // Add an element to this binary tree. Returns true if we successfully perform an insertion
        public bool Add(int element)
        {
            // Check if	the value already exists in this binary tree, if it does ignore adding it
            if (Contains(element))
                return false;

            // Otherwise add this element to the binary tree  
            else
            {
                root = Add(root, element);
                nodeCount++;
                return true;
            }
        }

        // Private method to recursively add a value in the binary tree 
        private TreeNode Add(TreeNode node, int element)
        {
            // Base case: found a leaf node
            if (node == null)
                node = new TreeNode(null, null, element);

            // Place lower elements values in left subtree 
            else
            {
                if (element.CompareTo(node.data) < 0)
                    node.left = Add(node.left, element);
                else
                    node.right = Add(node.right, element);
            }

            return node;
        }

        // Remove a value from this binary tree, if it exists
        public bool Remove(int element)
        {
            if (Contains(element))
            {
                root = Remove(root, element);
                nodeCount--;
                return true;
            }
            return false;
        }

        private TreeNode Remove(TreeNode node, int element)
        {
            if (node == null) return null;

            int cmp = element.CompareTo(node.data);

            // Dig into left subtree, the value we're looking for is smaller than the current value
            if (cmp < 0)
                node.left = Remove(node.left, element);

            // Dig into right subtree, the value we're looking for is greater than the current value
            else if (cmp > 0)
                node.right = Remove(node.right, element);

            // Found the node we wish to remove
            else
            {
                // This is the case with only a right subtree or no subtree at all. In this situation just
                // swap the node we wish to remove with its right child
                if (node.left == null)
                {
                    TreeNode rightChild = node.right;

                    node.data = -11111;
                    node = null;

                    return rightChild;
                }

                // This is the case with only a left subtree or no subtree at all. In this situation just
                // swap the node we wish to remove with its left child
                else if (node.right == null)
                {
                    TreeNode leftChild = node.left;

                    node.data = -11111;
                    node = null;

                    return leftChild;
                }

                // When removing a node from a binary tree with two links the successor of the node being removed
                // can either be the largest value in the left subtree or the smallest value in the right subtree.
                // In this implementation I have decided to find the smallest value in the right subtree which can 
                // be found by traversing as far left as possible in the right subtree
                else
                {
                    // Find the leftmost node in the right subtree
                    TreeNode tmp = DigLeft(node.right);

                    // Swap the data
                    node.data = tmp.data;

                    // Go into the right subtree and remove the leftmost node we found and swapped data with. This 
                    // prevents us from having two nodes in our tree with the same value.
                    node.right = Remove(node.right, tmp.data);

                    // If instead we wanted to find the largest node in the left subtree as opposed to smallest node
                    // in the right subtree here is what we would do:
                    // Node.tmp = DigRight(node.left);
                    // Node.data = tmp.data;
                    // Node.left = Remove(node.left, tmp.data);
                }
            }

            return node;
        }

        // Helper method to find the leftmost node
        private TreeNode DigLeft(TreeNode node)
        {
            TreeNode cur = node;

            while (cur.left != null)
                cur = cur.left;
            return cur;
        }

        // Helper method to find the rightmost node
        private TreeNode DigRight(TreeNode node)
        {
            TreeNode cur = node;

            while (cur.right != null)
                cur = cur.right;
            return cur;
        }

        // Returns true is the element exists in the tree
        public bool Contains(int element)
        {
            return Contains(root, element);
        }

        // Private recursive method to find an element in the tree
        private bool Contains(TreeNode node, int element)
        {
            // Base case: reached bottom, value not found
            if (node == null) return false;

            int cmp = element.CompareTo(node.data);

            // Dig into the left subtree because the value we're looking for is smaller than the 
            // current value
            if(cmp < 0) return Contains(node.left, element);

            // Dig into the right subtree because the value we're looking for is greater than the 
            // current value
            else if(cmp > 0) return Contains(node.right, element);

            // We found the value we were looking for 
            else return true;
        }

        // Computes the height of the tree, O(n)
        public int Height()
        {
            return Height(root);
        }

        // Recursive helper method to compute the height of the tree
        private int Height(TreeNode node)
        {
            if(node == null) return 0;
            return Math.Max(Height(node.left), Height(node.right)) + 1;
        }
    }

    #endregion
}
