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
			var medium = new online_judge.leetcode.medium.Problem_325();
			var hard = new online_judge.leetcode.hard.Problem42();
			var explore = new online_judge.leetcode.explore.RecursionII();

			medium.MaxSubArrayLen(new int[] { 1, -1, 5, -2, 3 }, 3);
			medium.MaxSubArrayLen(new int[] { -2, -1, 2, 1 }, 1);




			Node node7 = new Node(7, null, null, null);
			Node node6 = new Node(15, null, null, null);
			Node node5 = new Node(5, null, null, null);
			Node node4 = new Node(4, null, null, null);
			Node node3 = new Node(20, node6, node7, null);
			Node node2 = new Node(9, null, null, null);
			Node node1 = new Node(3, node2, node3, null);

			
			//[3,9,20,null,null,15,7]

			//Node node6 = new Node(6, null, null, null);





			//var ret = medium.MinSubArrayLen( 11, new int[] { 1, 2, 3, 4, 5 });

			// [[1,4,5],[1,3,4],[2,6]]

			//ListNode node9 = new ListNode(10, null);
			//ListNode node8 = new ListNode(9, node9);

			//ListNode node7 = new ListNode(6, null);
			/*
			ListNode node6 = new ListNode(5, null);

			ListNode node5 = new ListNode(4, node6);
			ListNode node4 = new ListNode(4, node5);
			ListNode node3 = new ListNode(3, node4);

			ListNode node2 = new ListNode(3, node3);
			ListNode node1 = new ListNode(2, node2);
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
			//[[1,0,0,1],[0,1,1,0],[0,1,1,1],[1,0,1,1]]
			/*
			var ret = medium.FindCircleNum(new int[][] {
					new int [] {1, 1, 1, 0 },
					new int [] {1, 1, 1, 0 },
					new int [] {1, 1, 1, 0 },
					new int [] {0, 0, 0, 1 }
				});

			ret = medium.FindCircleNum(new int[][] {
					new int [] {1, 0, 0, 1 },
					new int [] {0, 1, 1, 0 },
					new int [] {0, 1, 1, 1 },
					new int [] {1, 0, 1, 1 }
				});
			ret = medium.FindCircleNum(new int[][] {
					new int [] {1,1,1,1,0 },
					new int [] {1,1,1,1,0 },
					new int [] {1,1,1,1,0  },
					new int [] { 1, 1, 1, 1, 0 },
					new int [] { 0,0,0,0, 1 },
				});
			*/

			/*
			var ret = medium.SearchMatrix(new int[][] {
					new int[] { 1,3,5,7 },
					new int[] { 10,11,16,20 },
					new int[] { 23,30,34,60 }
				}, 3);
			ret = medium.SearchMatrix(new int[][] {
					new int[] { 1,3,5,7 },
					new int[] { 10,11,16,20 },
					new int[] { 23,30,34,60 }
				}, 13);
			*/
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
