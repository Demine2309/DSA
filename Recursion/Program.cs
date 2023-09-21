using System.Text;

namespace DSA
{
    public class Solution
    {
        #region Factorial of a number
        //public int Factorial(int num)
        //{
        //    if(num == 0) 
        //        return 1;
        //    else
        //        return num * Factorial(num - 1);
        //}
        #endregion

        #region Recursion 1: Tower of Ha Noi
        ///* Tower of Hanoi is a mathematical puzzle where we have three rods (A, B and C) and N disks. Initially, all the disks are
        // * stacked in decreasing value of diameter i.e., the smallest disk is placed on the top and they are on rod A. The objective
        // * of the puzzle is to move the entire stack to another rod (here considered C), obeying the following simple rules:
        // * - Only one disk can be moved at a time .
        // * - Each move consists of taking the upper disk from one of the stacks and placing it on top of another stack i.e. A disk
        // *   can only be moved if it is the uppermost disk on a stack.
        // * - No disk may be placed on top of smaller disk.
        //*/

        ///* The idea is to use the helper node to reach the destination using recursion. Below is the pattern for this problem:
        // *  - Shift 'N - 1' disks from 'A' to 'B', using C.
        // *  - Shift last disk from 'A' to 'C'.
        // *  - Shift 'N - 1' disks from 'B' to 'C', using A.
        // */
        //public void TowerOfHanoi(int n, Char fromRod, char toRod, char auxRod)
        //{
        //    if (n == 0) return;
        //    TowerOfHanoi(n - 1, fromRod, auxRod, toRod);
        //    Console.WriteLine("Move disk " + n + " from rod " + fromRod + " to rod " + toRod);
        //    TowerOfHanoi(n - 1, auxRod, toRod, fromRod);
        //}
        #endregion

        #region Recursion 2: 
        
        #endregion
    }

    public class MainClass
    {
        #region Factorial of a number
        //static void Main(string[] args)   
        //{
        //    Console.OutputEncoding = Encoding.Unicode;

        //    Solution solution = new Solution();

        //    Console.WriteLine($"Tính giai thừa của 6: 6! = {solution.Factorial(6)}");
        //}
        #endregion

        #region Recursion 1: Tower of Ha Noi
        //static void Main(string[] args)
        //{
        //    Solution solution = new Solution();

        //    char fromRod = 'A', toRod = 'B', auxRod = 'C';

        //    Console.Write("Enter numbers of disk: ");
        //    int n = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Result...");
        //    solution.TowerOfHanoi(n, fromRod, toRod, auxRod);
        //}
        #endregion

        #region Recursion 2:
        static void Main(string[] args)
        {
            Solution solution = new Solution();


        }
        #endregion
    }
}