namespace DSA
{
	#region First Repeat
	public class Solution
	{
		public char FirstRepeatedChar(string str)
		{
			int[] count = new int[256];

			for(int i = 0; i < 256; i++)
				count[i] = 0;
			
			for(int i = 0; i < str.Length; i++)
			{
				if (count[str[i]] == 1)
				{
					Console.Write(str[i]);
					break;
				}
				else
					count[str[i]]++;
			}
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();


		}
	}
	#endregion
}