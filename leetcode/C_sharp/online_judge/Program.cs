﻿using online_judge.leetcode;
using online_judge.leetcode.easy;
using online_judge.leetcode.medium;
using System;


namespace online_judge
{
    class Program
    {
		static void Main(string[] args)
		{
			/*
				string[] lines = File.ReadAllLines(@"input.txt");
				foreach (string line in lines)
				{
					Console.WriteLine(line);
				}
			*/
			var easy = new online_judge.leetcode.easy.Problem_14();
			var medium = new online_judge.leetcode.medium.Problem33();
			var hard = new online_judge.leetcode.hard.Problem42();
			var explore = new online_judge.leetcode.explore.RecursionII();

			// [[1,4,5],[1,3,4],[2,6]]
			/*
			ListNode node9 = new ListNode(10, null);
			ListNode node8 = new ListNode(9, node9);

			ListNode node7 = new ListNode(6, null);
			ListNode node6 = new ListNode(2, node7);

			ListNode node5 = new ListNode(4, null);
			ListNode node4 = new ListNode(3, node5);
			ListNode node3 = new ListNode(1, node4);

			ListNode node2 = new ListNode(5, null);
			ListNode node1 = new ListNode(4, node2);
			ListNode head = new ListNode(1, node1);
			*/
			//var ret = medium.LengthOfLongestSubstring2("bbbbb");
			//var ret = easy.LongestCommonPrefix(new string[] { "baac", "acb", "bacc", "cb"});
			//ret = easy.LongestCommonPrefix(new string[] { "flow", "flower", "flight" });
			//ret = easy.LongestCommonPrefix(new string[] { "do", "racecar", "car" });
			//ret = easy.LongestCommonPrefix(new string[] { "abc", "ab", "a" });
			/*
			var ret = medium.Exist(new char[][] { 
				new char[] { 'A', 'A' },
			}
			, "AA");
			*/
			//var ret = medium.SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8);
			//ret = medium.SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 6);
			var ret = medium.Search(new int[] { 8,9,2,3,4 }, 9);
			/*
			ret = medium.Exist(new char[][] {
				new char[] { 'A', 'B', 'C', 'E' },
				new char[] { 'S', 'F', 'C', 'S' },
				new char[] { 'A', 'D', 'E', 'E' }}
			, "ABCB");
			*/
			/*
			var ret = hard.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
			Console.WriteLine("ret:" + ret);
			ret = hard.Trap(new int[] { 4, 2, 0, 3, 2, 5 });
			Console.WriteLine("ret:" + ret);
			*/

		}
    }
}
