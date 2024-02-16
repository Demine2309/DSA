namespace DSA
{
    class TestClass
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[3];
            myArray[0] = 17;

            foreach(int i in myArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}