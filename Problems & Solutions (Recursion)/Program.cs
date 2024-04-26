namespace DSA
{
	#region Problem 1: Discuss Towers of Hanoi puzzle
	public class Solution
	{
		public void TowerOfHanoi(int n, char fromPeg, char topPeg, char auxPeg) // A: fromPeg, B: topPeg, C: auxPeg
		{
			if (n == 1)
			{
				Console.WriteLine($"Move disk 1 from peg {fromPeg} to peg {topPeg}");
				return;
			}

			// Move top n - 1 disks from A to B, using C as auxiliary
			TowerOfHanoi(n - 1, fromPeg, auxPeg, topPeg);

			// Move remaining disks from A to C
			Console.WriteLine($"Move disk {n} from peg {fromPeg} to peg {topPeg}");

			// Move n-1 disks from B to C using A as auxiliary
			TowerOfHanoi(n - 1, auxPeg, topPeg, fromPeg);
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();

			int n = 4; // The number of disks

			Console.WriteLine("Start...");

			solution.TowerOfHanoi(n, 'A', 'B', 'C');

			Console.WriteLine("End!");
		}
	}
	#endregion

	#region Problem 2: Given an array, check whether the array is in sorted order with recursion
	//public class Solution
	//{
	//	public bool CheckArrayIsSorted(int[] arr)
	//	{

	//	}
	//}

	//class MainClass
	//{
	//	static void Main(string[] args)
	//	{
	//		Solution solution = new Solution();


	//	}
	//}
	#endregion
}