using System;

public class LongestCommonPrefix
{
	public static string Go(string[] strs)
	{
		var f = "";
		var lStr = strs.MaxBy(x => x.Length) ?? "";
		for (int i = 0; i < lStr.Length; i++)
		{
			if (!strs.All(x => i < x.Length && x[i] == lStr[i])) return f;
			f += lStr[i];
		}
		return f;
	}
}
