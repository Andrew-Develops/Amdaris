using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class OptionalAssignment
    {
        // how many XML tags are out of order
        // "<app><app><app></app></app>"; => 1
        // "<app></app></app><app><app>"; => 3
        // "</app><app><app></app></app>"; => 1

        public static int solution(String s)
        {
            Stack<string> stack = new Stack<string>();
            string[] tags = s.Split(">");
            int count = 0;
            foreach (string tag in tags)
            {
                if (tag.StartsWith("</"))
                {
                    if (stack.Count == 0)
                    {
                        count++;
                    }
                    else
                    {
                        string top = stack.Pop();
                        if (!top.Equals(tag.Substring(2)))
                        {
                            count++;
                        }
                    }
                }
                else if (tag.StartsWith("<"))
                {
                    stack.Push(tag.Substring(1));
                }
            }
            return count + stack.Count;
        }
    }
}

