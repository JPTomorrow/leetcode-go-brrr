using System;
using System.Transactions;

// public class ListNode
// {
// 	public int val;
// 	public ListNode next;
// 	public ListNode(int val = 0, ListNode next = null)
// 	{
// 		this.val = val;
// 		this.next = next;
// 	}
// }

// public class MergeSortedLinkedLists
// {
// 	public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
// 	{
// 		ListNode retNode = new ListNode(list1.val > list2.val ? list1.val : list2.val);
// 		var n1 = list1.next;
// 		var n2 = list2.next;
// 		while (true)
// 		{
// 			if (n1.val >= n2.val)
// 			{
// 				retNode.next = n1;
// 				n1 = n1.next;
// 			}
// 			if (n1.val < n2.val)
// 			{
// 				retNode.next = n2;
// 				n2 = n2.next;
// 			}
// 		}
// 	}
// }
