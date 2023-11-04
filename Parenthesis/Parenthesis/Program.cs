using System;
using System.Linq;

public class Solution
{
    public static void Main()
    {
        Solution s = new Solution();
        Console.WriteLine(s.IsValid("()[]{}"));
    }
    public bool IsValid(string s)
    {
        if (s.Length <= 1)
            return false;
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(')
                stack.Push(')');
            else if (c == '{')
                stack.Push('}');
            else if (c == '[')
                stack.Push(']');
            else if (stack.Count == 0 || stack.Pop() != c)
                return false;
        }
        return stack.Count == 0;
    }
}
