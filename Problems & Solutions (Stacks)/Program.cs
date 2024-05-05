using Microsoft.VisualBasic;
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

    //public class Solution
    //{
    //    public string ConvertInfixToPostfix(string str)
    //    {
    //        Stack<char> myStack = new Stack<char>();
    //        string result = String.Empty;

    //        for (int i = 0; i < str.Length; i++)
    //        {
    //            char c = str[i];

    //            if (Char.IsLetterOrDigit(c))
    //                result += c;

    //            else if (c == '(')
    //                myStack.Push(c);

    //            else if (c == ')')
    //            {
    //                while (myStack.Count != 0 && myStack.Peek() != '(')
    //                    result += myStack.Pop();

    //                if (myStack.Count != 0 && myStack.Peek() != '(')
    //                    return "Invalid expression";
    //                else
    //                    myStack.Pop();
    //            }
    //            else
    //            {
    //                while (myStack.Count != 0 && Prec(c) <= Prec(myStack.Peek()))
    //                    result += myStack.Pop();
    //                myStack.Push(c);
    //            }
    //        }
    //        while (myStack.Count != 0)
    //            result += myStack.Pop();

    //        return result;
    //    }

    //    private int Prec(char ch) // The "Prec" function in the provided C# code is used to get the precedence of the operators
    //                              // used in the infix expression
    //    {
    //        switch (ch)
    //        {
    //            case '+':
    //            case '-':
    //                return 1;

    //            case '*':
    //            case '/':
    //                return 2;

    //            case '^':
    //                return 3;
    //        }

    //        return -1;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();
    //        string str = "(A+B)+(C-D)";
    //        string str2 = "((A+B)-(C+D))*E-(F+K)";

    //        Console.WriteLine(solution.ConvertInfixToPostfix(str)); // Expect output: AB+CD-+
    //        Console.WriteLine(solution.ConvertInfixToPostfix(str2)); // Expect output: AB+CD+-E*FK+-
    //    }
    //}
    #endregion

    #region Problem 3. Discuss postfix evaluation using stack?? (too hard)
    ///*
    // * * Algorithm:
    // *      1. Scan the Postfix string from left to right.
    // *      2. Initialize an empty stack.
    // *      3. Repeat steps 4 and 5 till all the characters are scanned.
    // *      4. If the scanned character is an operand, push it onto the stack.
    // *      5. If the scanned character is an operator, and if the operator is a unary operator, then pop an element
    // *         from the stack. If the operator is a binary operator, then pop two elements from the stack. After popping the elements, 
    // *         apply the operator to those popped elements. Let the result of this operation be retVal onto the stack.
    // *      6. After all characters are scanned, we will have only one element in the stack. 
    // *      7. Return top of the stack as result.
    // */

    //public class Solution
    //{
    //    public int PostfixEvaluation(string str)
    //    {
    //        Stack<int> myStack = new Stack<int>();
    //        int num = 0;
    //        bool isNum = false;

    //        for (int i = 0; i < str.Length; i++)
    //        {
    //            if (Char.IsDigit(str[i]))
    //            {
    //                num = num * 10 + (str[i] - '0');
    //                isNum = true;
    //            }
    //            else
    //            {
    //                if (isNum)
    //                {
    //                    myStack.Push(num);
    //                    num = 0;
    //                    isNum = false;
    //                }

    //                if (myStack.Count < 2)
    //                {
    //                    Console.WriteLine("Error: Invalid postfix expression");
    //                    return -1;
    //                }

    //                int val1 = myStack.Pop();
    //                int val2 = myStack.Pop();

    //                switch (str[i])
    //                {
    //                    case '+':
    //                        myStack.Push(val1 + val2);
    //                        break;
    //                    case '-':
    //                        myStack.Push(val1 - val2);
    //                        break;
    //                    case '*':
    //                        myStack.Push(val1 * val2);
    //                        break;
    //                    case '/':
    //                        if (val1 == 0)
    //                        {
    //                            Console.WriteLine("Error: Division by zero");
    //                            return -1;
    //                        }
    //                        myStack.Push(val2 / val1);
    //                        break;

    //                    default:
    //                        Console.WriteLine("Error: Unknown operator");
    //                        return -1;
    //                }
    //            }
    //        }

    //        if (isNum)
    //        {
    //            myStack.Push(num);
    //        }

    //        if (myStack.Count != 1)
    //        {
    //            Console.WriteLine("Error: Invalid postfix expression");
    //            return -1;
    //        }

    //        return myStack.Pop();
    //    }

    //    //public int PostfixEvaluation(string str)
    //    //{
    //    //    Stack<int> myStack = new Stack<int>();
    //    //    for (int i = 0; i < str.Length; i++)
    //    //    {
    //    //        if (Char.IsDigit(str[i]))
    //    //        {
    //    //            myStack.Push(str[i] - '0'); // Convert char to int
    //    //        }
    //    //        else
    //    //        {
    //    //            int val1 = myStack.Pop();
    //    //            int val2 = myStack.Pop();
    //    //            switch (str[i])
    //    //            {
    //    //                case '+':
    //    //                    myStack.Push(val2 + val1);
    //    //                    break;

    //    //                case '-':
    //    //                    myStack.Push(val2 - val1);
    //    //                    break;

    //    //                case '*':
    //    //                    myStack.Push(val2 * val1);
    //    //                    break;

    //    //                case '/':
    //    //                    myStack.Push(val2 / val1);
    //    //                    break;
    //    //            }
    //    //        }
    //    //    }
    //    //    return myStack.Pop();
    //    //}

    //    public string ConvertInfixToPostfix(string str)
    //    {
    //        Stack<char> myStack = new Stack<char>();
    //        string result = String.Empty;

    //        for (int i = 0; i < str.Length; i++)
    //        {
    //            char c = str[i];

    //            if (Char.IsLetterOrDigit(c))
    //                result += c;

    //            else if (c == '(')
    //                myStack.Push(c);

    //            else if (c == ')')
    //            {
    //                while (myStack.Count != 0 && myStack.Peek() != '(')
    //                    result += myStack.Pop();

    //                if (myStack.Count != 0 && myStack.Peek() != '(')
    //                    return "Invalid expression";
    //                else
    //                    myStack.Pop();
    //            }
    //            else
    //            {
    //                while (myStack.Count != 0 && Prec(c) <= Prec(myStack.Peek()))
    //                    result += myStack.Pop();
    //                myStack.Push(c);
    //            }
    //        }
    //        while (myStack.Count != 0)
    //            result += myStack.Pop();

    //        return result;
    //    }

    //    private int Prec(char ch) // The "Prec" function in the provided C# code is used to get the precedence of the operators
    //                              // used in the infix expression
    //    {
    //        switch (ch)
    //        {
    //            case '+':
    //            case '-':
    //                return 1;

    //            case '*':
    //            case '/':
    //                return 2;

    //            case '^':
    //                return 3;
    //        }

    //        return -1;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        string str = "((10+11)-(12+9))*1-(1+1)";

    //        Console.WriteLine(solution.PostfixEvaluation(solution.ConvertInfixToPostfix(str)));
    //    }
    //}
    #endregion

    #region Problem 5. How to design a stack such that GetMinimum() should be O(1)
    /*
     * * Solution: Take an auxiliary stack that maintains the minimum of all values in the stack. Also, assume 
     *             that each element of the stack is less than its below elements. For simplicity let us call the
     *             auxiliary stack min stack.
     */

    //public class Solution
    //{
    //    private Stack<int> mainStack = new Stack<int>();
    //    private Stack<int> minStack = new Stack<int>();

    //    public void Push(int x)
    //    {
    //        mainStack.Push(x);
    //        if(mainStack.Count == 0 || x < minStack.Peek())
    //        {
    //            minStack.Push(x);
    //        }
    //    }

    //    public void Pop()
    //    {
    //        if(mainStack.Count > 0)
    //        {
    //            int x = mainStack.Pop();
    //            if(minStack.Count > 0 && x == minStack.Peek())
    //            {
    //                minStack.Pop();
    //            }
    //        }
    //    }

    //    public int Top()
    //    {
    //        return mainStack.Peek();
    //    }

    //    public int GetMinimum()
    //    {
    //        return minStack.Peek();
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution minStack = new Solution();

    //        minStack.Push(5);
    //        minStack.Push(2);
    //        minStack.Push(10);
    //        minStack.Push(1);
    //        Console.WriteLine("Minimum: " + minStack.GetMinimum()); // Output: 1
    //        minStack.Pop();
    //        Console.WriteLine("Minimum: " + minStack.GetMinimum()); // Output: 2
    //    }
    //}
    #endregion

    #region Problem 8. Given an array of characters formed with a's and b's. The string is marked with special character X which represents the middle of the list (for example: ababa...ababXbabab baaa). Check whether the string is palindrome
    //public class Solution
    //{
    //    public bool IsPalindrome(string str)
    //    {
    //        Stack<char> myStack = new Stack<char>();

    //        if (str.Length % 2 == 0)
    //        {
    //            for(int i = 0; i < str.Length / 2; i++)
    //            {
    //                myStack.Push(str[i]);

    //                if (myStack.Peek() != str[str.Length - 1 - i])
    //                    return false;
    //                else
    //                    myStack.Pop();
    //            }
    //        }
    //        else
    //        {
    //            if (str[(str.Length - 1) / 2] != 'X')
    //                return false;

    //            for (int i = 0; i < (str.Length - 1) / 2; i++)
    //            {
    //                myStack.Push(str[i]);

    //                if (myStack.Peek() != str[str.Length - 1 - i])
    //                    return false;
    //                else
    //                    myStack.Pop();
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

    //        string str = "aaababaaa";

    //        Console.WriteLine(solution.IsPalindrome(str));
    //    }
    //}
    #endregion

    #region Problem 11. Given a stack, how to reverse the elements of the stack using only stack operations (push & pop)?
    // Hint: Use Recursion!!!
    public class Solution
    {
        public void ReverseStack(Stack<int> stack)
        {
            if(stack.Count > 0)
            {
                int temp = stack.Pop();

                ReverseStack(stack);

                InsertAtBottom(stack, temp);
            }
        }

        private void InsertAtBottom(Stack<int> stack, int item)
        {
            if(stack.Count == 0)
                stack.Push(item);
            else
            {
                int temp = stack.Pop();

                InsertAtBottom(stack, item);

                stack.Push(temp);
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            Stack<int> myStack = new Stack<int>();

            myStack.Push(3);
            myStack.Push(9);
            myStack.Push(13);
            myStack.Push(23);
            myStack.Push(39);
            myStack.Push(46);

            DisplayStack(myStack);

            solution.ReverseStack(myStack);

            DisplayStack(myStack);
        }

        static void DisplayStack(Stack<int> stack)
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("The stack is empty.");
                return;
            }

            Console.WriteLine("Stack contents:");
            foreach (int item in stack)
            {
                Console.Write(item + "  ");
            }

            Console.WriteLine();
        }
    }
    #endregion
}