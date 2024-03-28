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
	 * 3. 
	 */
	#endregion
}