namespace DSA
{
    #region Learn Data structure & Algorithm with William Fiset
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
	 * 
	 */
    #endregion
}