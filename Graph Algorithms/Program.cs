namespace DSA
{
    public class Graph
    {
        private int numVertices;
        private int[, ] adjMatrix;

        public Graph(int numVertices)
        {
            this.numVertices = numVertices;
            adjMatrix = new int[numVertices, numVertices];
        }

        public void AddEdge(int org, int dest)
        {
            if(org >=0 && org < numVertices && dest >= 0 && dest < numVertices)
            {
                adjMatrix[org, dest] = 1;
                adjMatrix[dest, org] = 1;
            }
            else
            {
                Console.WriteLine("Invalid edge");
            }
        }

        public void RemoveEdge(int org, int dest)
        {
            if (org >= 0 && org < numVertices && dest >= 0 && dest < numVertices)
            {
                adjMatrix[org, dest] = 0;
                adjMatrix[dest, org] = 0;
            }
            else
            {
                Console.WriteLine("Invalid edge");
            }
        }

        public void Display()
        {
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    Console.Write(adjMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(5);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 4);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);

            graph.Display();
        }
    }
}