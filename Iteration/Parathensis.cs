using System;
using System.Collections.Generic;
using System.Linq;

namespace Iteration
{
    public class Parathensis
    {
        public int solution(string S)
        {
            var stringValue =  S.ToCharArray();
            Stack<char> stack = new Stack<char>();
            foreach (var s in stringValue)
            {
                switch (s)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(s);
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                        {
                            return 0;
                        }

                        break;
                    case ']':
                        if (stack.Count == 0 ||stack.Pop() != '[')
                        {
                            return 0;
                        }

                        break;
                    case '}':
                        if (stack.Count == 0 ||stack.Pop() != '{')
                        {
                            return 0;
                        }

                        break;
                    default:
                        throw new NotImplementedException("unexpected value");
                }
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}