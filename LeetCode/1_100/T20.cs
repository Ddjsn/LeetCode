using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode._1_100
{
    /// <summary>
    /// 有效的括号 
    /// https://leetcode-cn.com/problems/valid-parentheses/
    /// </summary>
    public class T20
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            return My(s);
        }
        /// <summary>
        /// 我的
        /// </summary>
        /// <returns></returns>
        public bool My(string s)
        {
            var chars = s.ToCharArray();
            var leftStack = new Stack<char>();
            foreach (var item in chars)
            {
                if (item == '(' || item == '[' || item == '{')
                {
                    leftStack.Push(item);
                }
                else
                {
                    if (leftStack.Count == 0)
                    {
                        return false;
                    }
                    var top = leftStack.Peek();
                    switch (item)
                    {
                        case '}':
                            if (top != '{')
                            {
                                return false;
                            }
                            leftStack.Pop();
                            break;
                        case ']':
                            if (top != '[')
                            {
                                return false;
                            }
                            leftStack.Pop();
                            break;
                        case ')':
                            if (top != '(')
                            {
                                return false;
                            }
                            leftStack.Pop();
                            break;
                        default:
                            return false;
                    }
                }
            }
            if (leftStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Other(string s)
        {
            var chars = s.ToCharArray();
            if(chars.Length % 2 == 1)
            {
                return false;
            }
            var leftStack = new Stack<char>();
            var map = new Dictionary<char, char> {
                { ']', '[' },
                {')','(' },
                {'}','{' },
            };
            foreach (var item in chars)
            {
                if (!map.ContainsKey(item))
                {
                    leftStack.Push(item);
                }
                else
                {
                    if (leftStack.Count == 0)
                    {
                        return false;
                    }
                    var top = leftStack.Peek();
                    if(map[item] == top)
                    {
                        leftStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (leftStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}