using System;
using System.Collections.Generic;

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
     * - In the Knapsack problem, 
     */
    #endregion
    #endregion
}

