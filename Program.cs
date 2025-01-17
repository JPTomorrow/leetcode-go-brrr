using System.Diagnostics;


// OLD WAY OF DOING MAIN
//public class App
//{
//	public static void Main(string[] args)
//	{
//		Console.WriteLine("Hello, World!");
//	}
//}

// TOP LEVEL STATEMENTS MMMMMMMMMM...

Console.WriteLine("Leetcode go brrrrrr!");

var twoSum = TwoSum.Go(new[] { 2, 7, 10, 11 }, 9);
Debug.Assert(twoSum.Length == 2 && twoSum[0] == 0 && twoSum[1] == 1);

var palindromeNumber = PalindromeNumber.Go(121);
Debug.Assert(palindromeNumber);

var lcprefix = LongestCommonPrefix.Go(new[] { "asser", "assist", "assortment" });
Debug.Assert(lcprefix == "ass");

var validParenthesses1 = ValidParentheses.Go("(a{b[c]d}e)");
var validParenthesses2 = ValidParentheses.Go("({[}])");
var validParenthesses3 = ValidParentheses.Go("]");
Debug.Assert(validParenthesses1);
Debug.Assert(!validParenthesses2);
Debug.Assert(!validParenthesses3);


