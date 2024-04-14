using System;
using System.Collections.Generic;
using Google.OrTools.Algorithms;

namespace DSA
{
    #region Part 1
    //public class NQueenProblem
    //{
    //    private bool Validate(int[,] board, int i, int j)
    //    {
    //        // validate rows
    //        int c;
    //        for (c = 1; c <= j; c++)
    //        {
    //            if (board[i - 1, c - 1] == 1)
    //            {
    //                return false;
    //            }
    //        }

    //        // validate columns
    //        int r;
    //        for (r = 1; r <= i; r++)
    //        {
    //            if (board[r - 1, j - 1] == 1)
    //            {
    //                return false;
    //            }
    //        }

    //        // validate diagonals to right up corner
    //        c = j;
    //        r = i;
    //        while (c != 0 && r != 0)
    //        {
    //            if (board[r - 1, c - 1] == 1)
    //            {
    //                return false;
    //            }
    //            r--;
    //            c--;
    //        }

    //        // validate diagonals to left up corner
    //        c = j;
    //        r = i;
    //        while (c != board.GetLength(1) + 1 && r != 0)
    //        {
    //            if (board[r - 1, c - 1] == 1)
    //            {
    //                return false;
    //            }
    //            r--;
    //            c++;
    //        }

    //        return true;
    //    }

    //    public void NQueen(int n)
    //    {
    //        int[,] board = new int[n, n];
    //        Stack<int[]> queensPositions = new Stack<int[]>(); // stores positions of added queens

    //        int j = 1;
    //        for (int i = 1; i <= board.GetLength(0); i++)
    //        {
    //            for (; j <= board.GetLength(1); j++)
    //            {
    //                if (Validate(board, i, j))
    //                {
    //                    // check validity of cell before adding the queen
    //                    board[i - 1, j - 1] = 1;
    //                    queensPositions.Push(new int[] { i, j });
    //                    break;
    //                }
    //            }

    //            j = 1;
    //            if (queensPositions.Count != i)
    //            {
    //                // checks if a queen was placed in the current row
    //                if (queensPositions.Count > 0)
    //                {
    //                    // position of last added queen
    //                    int[] qLast = queensPositions.Pop();

    //                    // backtracking
    //                    board[qLast[0] - 1, qLast[1] - 1] = 0; // nulling the last added queen
    //                    i = qLast[0] - 1; // going back to the row of the last added queen
    //                    j = qLast[1] + 1; // going back to the column of the last added queen + 1
    //                }
    //            }

    //            if (i == board.GetLength(0))
    //            {
    //                Print(board);
    //                Console.WriteLine();
    //                if (queensPositions.Count > 0)
    //                {
    //                    // position of last added queen
    //                    int[] qLast = queensPositions.Pop();

    //                    // backtracking
    //                    board[qLast[0] - 1, qLast[1] - 1] = 0; // nulling the last added queen
    //                    i = qLast[0] - 1; // going back to the row of the
    //                                      // last added queen
    //                    j = qLast[1] + 1; // going back to the column of
    //                                      // the last added queen + 1
    //                }
    //            }
    //        }
    //    }

    //    private void Print(int[,] board)
    //    {
    //        int count = 0;
    //        foreach (int el in board)
    //        {
    //            if (el == 1)
    //            {
    //                count++;
    //            }
    //        }

    //        // Not valid solution
    //        if (count != board.GetLength(0))
    //        {
    //            return;
    //        }

    //        // Print the matrix
    //        for (int i = 0; i < board.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < board.GetLength(1); j++)
    //            {
    //                Console.Write(board[i, j] + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(String[] args)
    //    {
    //        NQueenProblem nQueenProblem = new NQueenProblem();

    //        nQueenProblem.NQueen(8);

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Example Algorithms of Backtracking
    #region N-Queens Problem
    ///*
    // * - The N Queen is the problem of placing N chess queens on an N×N chessboard so that no two queens attack each other.
    // * - The idea is to place queens one by one in different columns, starting from the leftmost column. When we place a queen in a column,
    // *   we check for clashes with already placed queens. In the current column, if we find a row for which there is no clash, we mark this
    // *   row and column as part of the solution. If we do not find such a row due to clashes, then we backtrack and return false.
    // * * Follow the steps mentioned below to implement the idea:
    // * - Start in the leftmost column
    // * - If all queens are placed return true
    // * - Try all rows in the current column. Do the following for every row.
    // *  + If the queen can be placed safely in this row
    // *      . Then mark this [row, column] as part of the solution and recursively check if placing queen here leads to a solution.
    // *      . If placing the queen in [row, column] leads to a solution then return true.
    // *      . If placing queen doesn’t lead to a solution then unmark this [row, column] then backtrack and try other rows.
    // *  + If all rows have been tried and valid solution is not found return false to trigger backtracking.
    // */

    //public class Solution
    //{
    //    private bool Validate(int[,] board, int i, int j)
    //    {
    //        // validate rows
    //        int c;
    //        for (c = 1; c <= j; c++)
    //        {
    //            if (board[i - 1, c - 1] == 1)
    //            {
    //                return false;
    //            }
    //        }

    //        // validate columns
    //        int r;
    //        for (r = 1; r <= i; r++)
    //        {
    //            if (board[r - 1, j - 1] == 1)
    //            {
    //                return false;
    //            }
    //        }

    //        // validate diagonals to right up corner
    //        c = j;
    //        r = i;
    //        while (c != 0 && r != 0)
    //        {
    //            if (board[r - 1, c - 1] == 1)
    //            {
    //                return false;
    //            }
    //            r--;
    //            c--;
    //        }

    //        // validate diagonals to left up corner
    //        c = j;
    //        r = i;
    //        while (c != board.GetLength(1) + 1 && r != 0)
    //        {
    //            if (board[r - 1, c - 1] == 1)
    //            {
    //                return false;
    //            }
    //            r--;
    //            c++;
    //        }

    //        return true;
    //    }

    //    public void NQueen(int n)
    //    {
    //        int[,] board = new int[n, n];
    //        Stack<int[]> queensPositions = new Stack<int[]>(); // stores positions of added queens

    //        int j = 1;
    //        for (int i = 1; i <= board.GetLength(0); i++)
    //        {
    //            for (; j <= board.GetLength(1); j++)
    //            {
    //                if (Validate(board, i, j))
    //                {
    //                    // check validity of cell before adding the queen
    //                    board[i - 1, j - 1] = 1;
    //                    queensPositions.Push(new int[] { i, j });
    //                    break;
    //                }
    //            }

    //            j = 1;
    //            if (queensPositions.Count != i)
    //            {
    //                // checks if a queen was placed in the current row
    //                if (queensPositions.Count > 0)
    //                {
    //                    // position of last added queen
    //                    int[] qLast = queensPositions.Pop();

    //                    // backtracking
    //                    board[qLast[0] - 1, qLast[1] - 1] = 0; // nulling the last added queen
    //                    i = qLast[0] - 1; // going back to the row of the last added queen
    //                    j = qLast[1] + 1; // going back to the column of the last added queen + 1
    //                }
    //            }

    //            if (i == board.GetLength(0))
    //            {
    //                Print(board);
    //                Console.WriteLine();
    //                if (queensPositions.Count > 0)
    //                {
    //                    // position of last added queen
    //                    int[] qLast = queensPositions.Pop();

    //                    // backtracking
    //                    board[qLast[0] - 1, qLast[1] - 1] = 0; // nulling the last added queen
    //                    i = qLast[0] - 1; // going back to the row of the
    //                                      // last added queen
    //                    j = qLast[1] + 1; // going back to the column of
    //                                      // the last added queen + 1
    //                }
    //            }
    //        }
    //    }

    //    private void Print(int[,] board)
    //    {
    //        int count = 0;
    //        foreach (int el in board)
    //        {
    //            if (el == 1)
    //            {
    //                count++;
    //            }
    //        }

    //        // Not valid solution
    //        if (count != board.GetLength(0))
    //        {
    //            return;
    //        }

    //        // Print the matrix
    //        for (int i = 0; i < board.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < board.GetLength(1); j++)
    //            {
    //                Console.Write(board[i, j] + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int n = 4;

    //        solution.NQueen(n);

    //    }
    //}
    #endregion

    #region The Knapsack problem
    /*
     * - In the Knapsack problem, you need to pack a set of items, with given values and sizes (such as weights or volumes), into a container with a 
     *   maximum capacity. If the total size of the items exceeds the capacity, you can't pack them all. In that case, the problem is to choose a 
     *   subset of the items of maximum total value that will fit in the container 
     * * Step by step
     * 1. Create the data
     * - The data includes the following:
     *      + 'weights': A vector containing the weights of the items
     *      + 'values': A vector containing the values of the items
     *      + 'capacities': A vector with just one entry, the capacity of the knapsack
     * 2. Declare the solver
     * - The option "KNAPSACK_MULTIDIMENSION_BRANCH_AND_BOUND_SOLVER' tells the solver to use the branch and bound algorithm to solve the problem.
     * 3. Call the slover
     * - The program first initializes the solver, and then calls it by 'computedValue = solver.Solve()'. The total value of the optimal solution
     *   is 'computedValue', which is the same as the total weight in this case. The program then gets the indices of the packed items in the solution
     *   as follows:
     *              packed_items = [x for x in range(0, len(weights[0])) if solver.BestSolutionContains(x)]
     * - Since `solver.BestSolutionContains(x)` returns `TRUE` if the item x is included in the solution, `packed_items` is a list of the optimal packed 
     *   items. Similarly, `packed_weights` are the weights of the packed items. ### Output of the program Here is the output of the program.
     *      Total value = 7534
     *      Total weight: 850
     *      Packed items: [0, 1, 3, 4, 6, 10, 11, 12, 14, 15, 16, 17, 18, 19, 21, 22, 24, 27, 28, 29, 30, 31,
                           32, 34, 38, 39, 41, 42, 44, 47, 48, 49]
     *      Packed_weights: [7, 0, 22, 80, 11, 59, 18, 0, 3, 8, 15, 42, 9, 0, 47, 52, 26, 6, 29, 84, 2, 4,
                             18, 7, 71, 3, 66, 31, 0, 65, 52, 13]
     */
    class MainClass
    {
        static void Main(string[] args)
        {
            KnapsackSolver solver = new KnapsackSolver(KnapsackSolver.SolverType.KNAPSACK_MULTIDIMENSION_BRANCH_AND_BOUND_SOLVER, "KnapsackExample");

            long[] values = {360, 83, 59, 130, 431, 67,  230, 52,  93,  125, 670, 892, 600, 38,  48,  147, 78,
                  256, 63, 17, 120, 164, 432, 35,  92,  110, 22,  42,  50,  323, 514, 28,  87,  73,
                  78,  15, 26, 78,  210, 36,  85,  189, 274, 43,  33,  10,  19,  389, 276, 312 };
           
            long[,] weights = { { 7,  0,  30, 22, 80, 94, 11, 81, 70, 64, 59, 18, 0,  36, 3,  8,  15,
                      42, 9,  0,  42, 47, 52, 32, 26, 48, 55, 6,  29, 84, 2,  4,  18, 56,
                      7,  29, 93, 44, 71, 3,  86, 66, 31, 65, 0,  79, 20, 65, 52, 13 } };
            
            long[] capacities = { 850 };

            solver.Init(values, weights, capacities);
            long computedValue = solver.Solve();

            Console.WriteLine("Optimal Value = " + computedValue);
        }
    }
    #endregion
    #endregion
}

