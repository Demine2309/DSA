using System.Collections.Generic;
using System.Text;

namespace DSA
{
    #region Example: Being a very busy person, you have exactly T time to do some interseting things and you want to do maximum such things
    //public class Solution
    //{
    //    public int NumberOfThing(int[] A, int T)
    //    {
    //        int currentTime = A[0];
    //        int numberOfThing = 0;

    //        for (int i = 1; i < A.Length; i++)
    //        {
    //            if (currentTime <= T)
    //            {
    //                currentTime += A[i];
    //                numberOfThing++;
    //            }
    //        }

    //        return numberOfThing;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] A = { 5, 3, 4, 2, 1 };
    //        Array.Sort(A);

    //        int T = 6;

    //        Console.WriteLine(solution.NumberOfThing(A, T));
    //    }
    //}
    #endregion



    #region The scheduling problem
    //public class Solution
    //{
    //    public double CalculateObjectFunction(int[] P, int[] T, int N)
    //    {
    //        double[] S = new double[N]; // Array to store the scores
    //        double C = 0;               // Completion times
    //        double F = 0;               // Objective function

    //        for (int i = 0; i < N; i++)
    //        {
    //            S[i] = (double)P[i] / T[i];
    //        }

    //        Array.Sort(S);

    //        for (int i = 0; i < N; ++i)
    //        {
    //            int index = Array.IndexOf(S, (double)P[i] / T[i]);
    //            C += T[index];
    //            F += P[index] * C;
    //        }

    //        return F;
    //    }
    //}
    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {

    //        #region Example 2
    //        Solution solution = new Solution();

    //        int[] P = { 3, 1 };
    //        int[] T = { 5, 2 };
    //        int N = P.Length;

    //        double result = solution.CalculateObjectFunction(P, T, N);

    //        Console.WriteLine(result);
    //        #endregion
    //    }
    //}
    #endregion

    #region Huffman Coding Compression Algorithm
    public class HuffmanNode
    {
        public char Character { get; set; }
        public int Frequency { get; set; }
        public HuffmanNode Left { get; set; }
        public HuffmanNode Right { get; set; }
    }

    public class MinHeap
    {
        private List<HuffmanNode> heap;

        public MinHeap()
        {
            heap = new List<HuffmanNode>();
        }

        public int Size => heap.Count;

        public void Insert(HuffmanNode item)
        {
            heap.Add(item);
            HeapifyUp(heap.Count - 1);
        }

        public HuffmanNode ExtractMin()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");

            var min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);

            return min;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (heap[parent].Frequency > heap[index].Frequency)
                {
                    Swap(parent, index);
                    index = parent;
                }
                else
                {
                    break;
                }
            }
        }

        private void HeapifyDown(int index)
        {
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;
            int smallest = index;

            if (leftChild < heap.Count && heap[leftChild].Frequency < heap[smallest].Frequency)
                smallest = leftChild;
            if (rightChild < heap.Count && heap[rightChild].Frequency < heap[smallest].Frequency)
                smallest = rightChild;

            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }

        private void Swap(int i, int j)
        {
            var temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
    }

    public class HuffmanTree
    {
        public HuffmanNode Root { get; private set; }

        public HuffmanTree(Dictionary<char, int> charFrequencies)
        {
            // Build the Huffman tree
            var minHeap = new MinHeap();

            foreach (var kvp in charFrequencies)
            {
                minHeap.Insert(new HuffmanNode { Character = kvp.Key, Frequency = kvp.Value });
            }

            while (minHeap.Size > 1)
            {
                var left = minHeap.ExtractMin();
                var right = minHeap.ExtractMin();
                var newNode = new HuffmanNode
                {
                    Frequency = left.Frequency + right.Frequency,
                    Left = left,
                    Right = right
                };
                minHeap.Insert(newNode);
            }

            Root = minHeap.ExtractMin();
        }

        public string Encode(string text)
        {
            // Encode the input text using the Huffman tree
            var encoding = new Dictionary<char, string>();
            EncodeRecursive(Root, "", encoding);
            var encodedText = string.Join("", text.ToCharArray().Select(c => encoding[c]));
            return encodedText;
        }

        private void EncodeRecursive(HuffmanNode node, string code, Dictionary<char, string> encoding)
        {
            if (node.Character != null)
            {
                encoding[node.Character] = code;
            }
            else
            {
                EncodeRecursive(node.Left, code + "0", encoding);
                EncodeRecursive(node.Right, code + "1", encoding);
            }
        }

        public string Decode(string encodedText)
        {
            // Decode the input encoded text using the Huffman tree
            var decodedText = "";
            var currentNode = Root;
            foreach (var bit in encodedText)
            {
                currentNode = bit == '0' ? currentNode.Left : currentNode.Right;
                if (currentNode.Character != null)
                {
                    decodedText += currentNode.Character;
                    currentNode = Root;
                }
            }
            return decodedText;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            var inputText = "hello world!";
            var charFrequencies = new Dictionary<char, int>();

            foreach(char c in inputText)
            {
                if (charFrequencies.ContainsKey(c))
                    charFrequencies[c]++;
                else
                    charFrequencies[c] = 1;
            }

            var huffmanTree = new HuffmanTree(charFrequencies);
            var encodedText = huffmanTree.Encode(inputText);
            var decodedText = huffmanTree.Decode(encodedText);

            Console.WriteLine($"Input text: {inputText}");
            Console.WriteLine($"Encoded text: {encodedText}");
            Console.WriteLine($"Decoded text: {decodedText}");

        }
    }
    #endregion
}