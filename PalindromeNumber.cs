using System;

public class PalindromeNumber
{
	public static bool Go(int x)
	{
		if (x < 0) { return false; }
		string result = $"{x}";
		char[] chars = result.ToCharArray();
		for (int i = 0; i < chars.Length / 2; i++)
		{
			if (chars[i] != chars[chars.Length - 1 - i]) { return false; }
		}
		return true;
	}
}
