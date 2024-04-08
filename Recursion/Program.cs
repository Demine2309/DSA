using System.Numerics;
using System.Text;

namespace DSA
{
    #region Part 1
    //public class Solution
    //{
    //    #region Factorial of a number
    //    //public int Factorial(int num)
    //    //{
    //    //    if(num == 0) 
    //    //        return 1;
    //    //    else
    //    //        return num * Factorial(num - 1);
    //    //}
    //    #endregion

    //    #region Recursion 1: Tower of Ha Noi
    //    ///* Tower of Hanoi is a mathematical puzzle where we have three rods (A, B and C) and N disks. Initially, all the disks are
    //    // * stacked in decreasing value of diameter i.e., the smallest disk is placed on the top and they are on rod A. The objective
    //    // * of the puzzle is to move the entire stack to another rod (here considered C), obeying the following simple rules:
    //    // * - Only one disk can be moved at a time .
    //    // * - Each move consists of taking the upper disk from one of the stacks and placing it on top of another stack i.e. A disk
    //    // *   can only be moved if it is the uppermost disk on a stack.
    //    // * - No disk may be placed on top of smaller disk.
    //    //*/

    //    ///* The idea is to use the helper node to reach the destination using recursion. Below is the pattern for this problem:
    //    // *  - Shift 'N - 1' disks from 'A' to 'B', using C.
    //    // *  - Shift last disk from 'A' to 'C'.
    //    // *  - Shift 'N - 1' disks from 'B' to 'C', using A.
    //    // */
    //    //public void TowerOfHanoi(int n, Char fromRod, char toRod, char auxRod)
    //    //{
    //    //    if (n == 0) return;
    //    //    TowerOfHanoi(n - 1, fromRod, auxRod, toRod);
    //    //    Console.WriteLine("Move disk " + n + " from rod " + fromRod + " to rod " + toRod);
    //    //    TowerOfHanoi(n - 1, auxRod, toRod, fromRod);
    //    //}
    //    #endregion

    //    #region Recursion 2: 

    //    #endregion
    //}

    //public class MainClass
    //{
    //    #region Factorial of a number
    //    //static void Main(string[] args)   
    //    //{
    //    //    Console.OutputEncoding = Encoding.Unicode;

    //    //    Solution solution = new Solution();

    //    //    Console.WriteLine($"Tính giai thừa của 6: 6! = {solution.Factorial(6)}");
    //    //}
    //    #endregion

    //    #region Recursion 1: Tower of Ha Noi
    //    //static void Main(string[] args)
    //    //{
    //    //    Solution solution = new Solution();

    //    //    char fromRod = 'A', toRod = 'B', auxRod = 'C';

    //    //    Console.Write("Enter numbers of disk: ");
    //    //    int n = int.Parse(Console.ReadLine());

    //    //    Console.WriteLine("Result...");
    //    //    solution.TowerOfHanoi(n, fromRod, toRod, auxRod);
    //    //}
    //    #endregion

    //    #region Recursion 2:
    //    //static void Main(string[] args)
    //    //{
    //    //    Solution solution = new Solution();


    //    //}
    //    #endregion
    //}
    #endregion

    #region Example Algorithm of Recursion
    #region Fibonacci Series
    ///*
    // * * Theory
    // * - The Fibonacci series is the sequence of numbers (also called Fibonacci numbers), where every number is the sum of the preceding two numbers, 
    // *   such that the first two terms are '0' and '1'.
    // * - The Fibonacci series spiral is a logarithmic spriral that is formed by joining the corners of squares that have side lengths the same as the 
    // *   Fibonacci numbers in the Fibonacci sequence
    // * - Some of the applications of the series are given as:
    //        + It is used in the grouping of numbers and used to study different other special mathematical sequences.
    //        + It finds application in Coding (computer algorithms, distributed systems, etc). For example, Fibonacci series are important in the 
    //          computational run-time analysis of Euclid's algorithm, used for determining the GCF of two integers.
    //        + It is applied in numerous fields of science like quantum mechanics, cryptography, etc.
    //        + In finance market trading, Fibonacci retracement levels are widely used in technical analysis.
    // */
    //public class FibonacciSeries
    //{
    //    public int FibonacciSum(int x)
    //    {
    //        if (x == 0) return 0;
    //        if (x == 1) return 1;

    //        return FibonacciSum(x - 1) + FibonacciSum(x-2);
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        FibonacciSeries solution = new FibonacciSeries();

    //        int x = 6;
    //        Console.WriteLine(solution.FibonacciSum(x));
    //    }
    //}
    #endregion

    #region Factorial Finding
    //// Factorial of a non-negative integer is the multiplication of all positive integers smaller then or equal to n.
    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        int n = 0;

    //        Console.WriteLine($"{n}! = {FactorialOfN(n)}");
    //    }

    //    static int FactorialOfN(int n)
    //    {
    //        if (n == 0) return 1;

    //        return n*FactorialOfN(n-1);
    //    }
    //}
    #endregion

    #region Tower of Hanoi
    public class Solution
    {
        public void TowerOfHanoi(int n, char fromRod, char topRod, char auxRod)
        {
            // If only 1 disk, make the move and return
            if(n == 1)
            {
                Console.WriteLine($"Move disk 1 from rod {fromRod} to rod {topRod}");
                return;
            }

            // Move top n-1 disks from A to B, using C as auxiliary
            TowerOfHanoi(n - 1, fromRod, topRod, auxRod);

            // Move remaining disks from A to C
            Console.WriteLine($"Move disk {n} from rod {fromRod} to rod {topRod}");

            // Move n-1 disks from B to C using A as auxiliary
            TowerOfHanoi(n - 1, auxRod, topRod, fromRod);
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            solution.TowerOfHanoi(4, 'A', 'B', 'C');
        }
    }
    #endregion
    #endregion
}