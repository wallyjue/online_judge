using online_judge.leetcode;
using online_judge.leetcode.easy;
using online_judge.leetcode.medium;
using System;
using System.Collections.Generic;

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
			var easy = new online_judge.leetcode.easy.Problem94();
			var medium = new online_judge.leetcode.medium.Problem2370();
			var hard = new online_judge.leetcode.hard.Problem4();
			var explore = new online_judge.leetcode.explore.RecursionII();
			
			//medium.ThreeSumSmaller(new int[] { -2, 0, 1, 3 }, 2);
			medium.LongestIdealString("pvjcci", 4);
			medium.LongestIdealString("abcd", 3);
			//medium.ThreeSumSmaller(new int[] {4, 0, 5, -5, 3, 3, 0, -4, -5,-2 }, -2);
			//medium.ThreeSumSmaller(new int[] { 4 + 5, 0 + 5, 5 + 5, -5 + 5, 3 + 5, 3 + 5, 0 + 5, -4 + 5, -5+5, -2 + 5 }, -2+15);
			//medium.ThreeSumSmaller(new int[] { -43, 57, -71, 47, 3, 30, -85, 6, 60, -59, 0, -46, -40, -73, 53, 68, -82, -54, 88, 73, 20, -89, -22, 39, 55, -26, 95, -87, -57, -86, 28, -37, 43, -27, -24, -88, -35, 82, -3, 39, -85, -46, 37, 45, -24, 35, -49, -27, -96, 89, 87, -62, 85, -44, 64, 78, 14, 59, -55, -10, 0, 98, 50, -75, 11, 97, -72, 85, -68, -76, 44, -12, 76, 76, 8, -75, -64, -57, 29, -24, 27, -3, -45, -87, 48, 10, -13, 17, 94, -85, 11, -42, -98, 89, 97, -66, 66, 88, -89, 90, -68, -62, -21, 2, 37, -15, -13, -24, -23, 3, -58, -9, -71, 0, 37, -28, 22, 52, -34, 24, -8, -20, 29, -98, 55, 4, 36, -3, -9, 98, -26, 17, 82, 23, 56, 54, 53, 51, -50, 0, -15, -50, 84, -90, 90, 72, -46, -96, -56, -76, -32, -8, -69, -32, -41, -56, 69, -40, -25, -44, 49, -62, 36, -55, 41, 36, -60, 90, 37, 13, 87, 66, -40, 40, -35, -11, 31, -45, -62, 92, 96, 8, -4, -50, 87, -17, -64, 95, -89, 68, -51, -40, -85, 15, 50, -15, 0, -67, -55, 45, 11, -80, -45, -10, -8, 90, -23, -41, 80, 19, 29, 7 }, 255);
			//hard.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
			//hard.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4,5,6,7,8,9,1000 });


			/*
			medium.WordBreak("leetcode", new List<string> { "leet", "code" });
			medium.WordBreak("applepenapple", new List<string> { "apple", "pen" });
			medium.WordBreak("catsandog", new List<string> { "cats", "dog", "sand", "and", "cat" });
			*/
			Node node7 = new Node(7, null, null, null);
			Node node6 = new Node(15, null, null, null);
			Node node5 = new Node(5, null, null, null);
			Node node4 = new Node(4, null, null, null);
			Node node3 = new Node(20, node6, node7, null);
			Node node2 = new Node(9, null, null, null);
			Node node1 = new Node(3, node2, node3, null);



			TreeNode treenode6 = new TreeNode(7);
			TreeNode treenode5 = new TreeNode(6);
			TreeNode treenode4 = new TreeNode(5);
			TreeNode treenode3 = new TreeNode(4);
			TreeNode treenode2 = new TreeNode(3, treenode5, treenode6);
			TreeNode treenode1 = new TreeNode(2, treenode3, treenode4);
			TreeNode root = new TreeNode(1, treenode1, treenode2);

			
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
