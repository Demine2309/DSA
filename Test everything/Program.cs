namespace DSA
{
    class TestClass
    {
        static void Main(string[] args)
        {
            int n = 5;
             
            Console.WriteLine(Print(n));
        }

        public static int Print(int n)
        {
            if(n == 0)
                return 0;
            else
            {
                Console.WriteLine(n);
                return Print(n-1);
            }    
        }
    }
}