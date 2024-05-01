namespace DSA
{
    #region Problem 1. Discuss how stacks can be used for checking balancing of Symbols
    /*
	 ** Solution: Stacks can be used to check whether the given expression has balanced symbols.
	 * This algorithm is very usefull in compilers. Each time the parser reads one character at a time. 
	 * If the character is an opening delimiter such as (, {, or [- then it is written to the stack. When 
	 * a closing delimiter is encountered like ), }, or ]-the stack is popped.
	 * The opening and closing delimiters are then compared. If they match, the parsing of the string 
	 * continues. If they do not match, the parser indicates that there is an error on the line. A linear-time
	 * O(n) algorithm based on stack can be given as:
	 ** Algorithm:
	 *	a. Creat Stack.
	 *	b. While (end of input is not reached){
	 *		1. If the character read is not a symbol to be balanced, ignore it.
	 *		2. If the character is an opening symbol like (, [, {, push it onto the stack
	 *		3. If it is a closing symbol like ),],}, then if the stack is empty report an error. Otherwise pop the stack.
	 *		4. If the symbol popped is not the corresponding opening symbol, report an error
	 *	c. At end of input, if the stack is not empty report an error.
	 */

    public class ListNode
    {
        public int data;
        public ListNode next;

        public ListNode(int data)
        {
            this.data = data;
            next = null;
        }
    }

    public class Stack
    {
        private ListNode top;

        public Stack()
        {
            top = null;
        }

        public bool IsEmptyStack()
        {
            return top == null;
        }

        public void Push(int data)
        {
            var newNode = new ListNode(data);
            newNode.next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int poppedData = top.data;
            top = top.next;
            return poppedData;
        }

        public int Peek()
        {
            if (top == null)
                throw new InvalidOperationException("Stack is empty.");

            return top.data;
        }

        public void DeleteStack()
        {
            top = null;

            Console.WriteLine("Stack has been deleted.");
        }
    }

    public class Solution
    {
        public void CheckBalanceSymbols(Stack stack)
        {

        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push();

            Solution solution = new Solution();

            solution.CheckBalanceSymbols(myStack);
        }
    }
    #endregion
}