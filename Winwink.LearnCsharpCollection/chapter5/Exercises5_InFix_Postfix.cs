using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter5
{
    public class Exercises5_Infix_Postfix
    {
        //infix 10 * 5 + 4 / 2
        //postfix 10 5 * 4 2 / +
        //prefix + * 10 5 / 4 2

        public static void InfixToPostfixTest()
        {
            var infix = "a+b*(c^d-e)^(f+g* h)-i";
            var result = InfixToPostfix(infix);
            Console.WriteLine("postfix:" + result);
        }

        //infix: a+b*(c^d-e)^(f+g* h)-i
        //postfix: abcd^e-fgh*+^i-*+

        //copy from https://stackoverflow.com/questions/26699089/infix-to-postfix-using-stacks-java
        public static string InfixToPostfix(string infix)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder postfix = new StringBuilder(infix.Length);
            char c;

            for (int i = 0; i < infix.Length; i++)
            {
                c = infix[i];
                if (IsOeprand(c))
                {
                    postfix.Append(c);
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix.Append(stack.Pop());
                    }
                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        return null;//no '(' matched
                    }
                    else if (stack.Count > 0)
                    {
                        stack.Pop();//pop '('
                    }
                }
                else if (IsOperator(c))
                {
                    if (stack.Count > 0 && GetPrecedence(c) <= GetPrecedence(stack.Peek()))
                    {
                        postfix.Append(stack.Pop());
                    }
                    stack.Push(c);
                }
            }

            while (stack.Count > 0)
            {
                postfix.Append(stack.Pop());
            }
            return postfix.ToString();
        }

        private static readonly string _operators = "+-*/()^";
        private static bool IsOperator(char ch)
        {
            return _operators.Contains(ch);
        }

        private static int GetPrecedence(char ch)
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

        private static bool IsOeprand(char ch)
        {
            return (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z');
        }
    }
}
