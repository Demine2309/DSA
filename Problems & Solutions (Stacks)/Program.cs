using System.Runtime.CompilerServices;
using System.Security.Authentication;

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

    //public class ListNode<T>
    //{
    //    public T Data;
    //    public ListNode<T> Next;

    //    public ListNode(T data)
    //    {
    //        Data = data;
    //        Next = null;
    //    }
    //}

    //public class Stack<T>
    //{
    //    private ListNode<T> top;

    //    public Stack()
    //    {
    //        top = null;
    //    }

    //    public int Count()
    //    {
    //        int count = 0;
    //        ListNode<T> current = top;

    //        while (current != null)
    //        {
    //            count++;
    //            current = current.Next;
    //        }

    //        return count;
    //    }

    //    public bool IsEmptyStack()
    //    {
    //        return top == null;
    //    }

    //    public void Push(T data)
    //    {
    //        var newNode = new ListNode<T>(data);
    //        newNode.Next = top;
    //        top = newNode;
    //    }

    //    public T Pop()
    //    {
    //        if (top == null)
    //        {
    //            throw new InvalidOperationException("Stack is empty.");
    //        }

    //        T poppedData = top.Data;
    //        top = top.Next;
    //        return poppedData;
    //    }

    //    public T Peek()
    //    {
    //        if (top == null)
    //            throw new InvalidOperationException("Stack is empty.");

    //        return top.Data;
    //    }

    //    public void DeleteStack()
    //    {
    //        top = null;

    //        Console.WriteLine("Stack has been deleted.");
    //    }
    //}

    //public class Solution
    //{
    //    public bool CheckBalanceSymbols(string str)
    //    {
    //        Stack<char> myStack = new Stack<char>();

    //        char[] openingSymbols = new char[] { '(', '{', '[' };
    //        char[] closingSymbols = new char[] { ')', '}', ']' };

    //        Dictionary<char, char> matches = new Dictionary<char, char>
    //        {
    //            { ')', '('},
    //            { '}', '{'},
    //            { ']', '['}
    //        };

    //        foreach (char c in str)
    //        {
    //            if (openingSymbols.Contains(c))
    //            {
    //                myStack.Push(c);
    //            }
    //            else if (closingSymbols.Contains(c))
    //            {
    //                if (myStack.Count() == 0 || matches[c] != myStack.Pop())
    //                {
    //                    return false;
    //                }
    //            }
    //        }

    //        return myStack.Count() == 0;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();
    //        string str = "(){[]}";

    //        Console.WriteLine(solution.CheckBalanceSymbols(str));
    //    }
    //}
    #endregion

    #region Problem 2. Discuss infix to postfix conversion algorithm using stack
    /*
     ** Definition:
     *  - Indix: A indix expression is a single letter, or an operator, proceeded by one infix string and followed by Another
     *           Indix String. 
     *           Ex. A; A+B; (A+B)+(c-D)
     *  - Prefix: A prefix expression is a single letter, or an operator, followed by two prefix strings. Every prefix string 
     *            longer than a single variable contains an operator, first operand and second operand. 
     *            Ex. A; +AB; ++AB-CD
     *  - Postfix: A postfix expression (also called Reverse Polish Notation) is a single letter or an operator, preceded by 
     *             two postfix strings. Every postfix string longer than a single variable contains first and second operands
     *             followed by an operator.
     *             Ex. A; AB+; AB+CD-+
     */

    public class Solution
    {
        public string ConvertInfixToPostfix(string str)
        {
            Stack<char> myStack = new Stack<char>();
            string result = String.Empty;

            for(int i = 0;i< str.Length;i++)
            {
                char c = str[i];

                if (Char.IsLetterOrDigit(c))
                    result += c;

                else if(c == '(')
                    myStack.Push(c);

                else if(c == ')')
                {
                    while (myStack.Count != 0 && myStack.Peek() != '(')
                        result += myStack.Pop();

                    if (myStack.Count != 0 && myStack.Peek() != '(')
                        return "Invalid expression";
                    else
                        myStack.Pop();
                }
                else
                {
                    while(myStack.Count != 0 && Prec(c) <= Prec(myStack.Peek()))
                        result += myStack.Pop();
                    myStack.Push(c);
                }
            }
            while (myStack.Count != 0)
                result += myStack.Pop();

            return result;
        }

        private int Prec(char ch) // The "Prec" function in the provided C# code is used to get the precedence of the operators
                                  // used in the infix expression
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }

            return -1;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string str = "(A+B)+(C-D)";
            string str2 = "((A+B)-(C+D))*E-(F+K)";

            Console.WriteLine(solution.ConvertInfixToPostfix(str)); // Expect output: AB+CD-+
            Console.WriteLine(solution.ConvertInfixToPostfix(str2));
        }
    }
    #endregion
}