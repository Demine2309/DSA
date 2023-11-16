using System;
using System.Collections.Generic;

class NQueenProblem
{
    static void Print(int[,] board)
    {
        int count = 0;
        foreach (int el in board)
        {
            if (el == 1)
            {
                count++;
            }
        }

        // Not valid solution
        if (count != board.GetLength(0))
        {
            return;
        }

        // Print the matrix
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool Validate(int[,] board, int i, int j)
    {
        // validate rows
        int c;
        for (c = 1; c <= j; c++)
        {
            if (board[i - 1, c - 1] == 1)
            {
                return false;
            }
        }

        // validate columns
        int r;
        for (r = 1; r <= i; r++)
        {
            if (board[r - 1, j - 1] == 1)
            {
                return false;
            }
        }

        // validate diagonals to right up corner
        c = j;
        r = i;
        while (c != 0 && r != 0)
        {
            if (board[r - 1, c - 1] == 1)
            {
                return false;
            }
            r--;
            c--;
        }

        // validate diagonals to left up corner
        c = j;
        r = i;
        while (c != board.GetLength(1) + 1 && r != 0)
        {
            if (board[r - 1, c - 1] == 1)
            {
                return false;
            }
            r--;
            c++;
        }

        return true;
    }

    static void NQueen(int n)
    {
        int[,] board = new int[n, n];
        Stack<int[]> queensPositions = new Stack<int[]>(); // stores positions of added queens

        int j = 1;
        for (int i = 1; i <= board.GetLength(0); i++)
        {
            for (; j <= board.GetLength(1); j++)
            {
                if (Validate(board, i, j))
                {
                    // check validity of cell before adding the queen
                    board[i - 1, j - 1] = 1;
                    queensPositions.Push(new int[] { i, j });
                    break;
                }
            }

            j = 1;
            if (queensPositions.Count != i)
            {
                // checks if a queen was placed in the current row
                if (queensPositions.Count > 0)
                {
                    // position of last added queen
                    int[] qLast = queensPositions.Pop();

                    // backtracking
                    board[qLast[0] - 1, qLast[1] - 1] = 0; // nulling the last added queen
                    i = qLast[0] - 1; // going back to the row of the last added queen
                    j = qLast[1] + 1; // going back to the column of the last added queen + 1
                }
            }

            if (i == board.GetLength(0))
            {
                Print(board);
                Console.WriteLine();
                if (queensPositions.Count > 0)
                {
                    // position of last added queen
                    int[] qLast = queensPositions.Pop();

                    // backtracking
                    board[qLast[0] - 1, qLast[1] - 1] = 0; // nulling the last added queen
                    i = qLast[0] - 1; // going back to the row of the
                                      // last added queen
                    j = qLast[1] + 1; // going back to the column of
                                      // the last added queen + 1
                }
            }
        }
    }

    static void Main(String[] args)
    {
        NQueen(8);
    }
}
