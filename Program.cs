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
