using System;
using System.Text.RegularExpressions;

public class ValidParentheses
{
	public static bool Go(string s)
	{
		/* BAD 13ms
		var l = new Stack<char>();
		var validChars = new[] { '(', '{', '[', ')', '}', ']' };
		for (int i = 0; i < s.Length; i++)
		{
			if (!validChars.Any(x => x == s[i])) continue;
			if (validChars.Take(3).Any(x => x == s[i]))
			{
				l.Push(s[i]);
				continue;
			}
			if (l.Count == 0) return false;
			var idx = validChars.ToList().FindIndex(x => x == s[i]);
			if (validChars.Any(x => x == s[i]) && validChars[idx - 3] == l.Peek())
			{
				l.Pop();
			}
			else
			{
				return false;
			}
		}
		return l.Count == 0;
		*/

		Stack<char> stack = new Stack<char>();

		foreach (char ch in s)
		{
			if (ch == '(') stack.Push(')');
			else if (ch == '{') stack.Push('}');
			else if (ch == '[') stack.Push(']');
			else
			{
				if (stack.Count == 0 || stack.Pop() != ch)
				{
					return false;
				}
			}
		}

		return stack.Count == 0;
	}
}
