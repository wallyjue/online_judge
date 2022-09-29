using online_judge.leetcode;
using online_judge.leetcode.easy;
using online_judge.leetcode.hard;
using online_judge.leetcode.medium;
using System;
using System.Collections.Generic;
using System.Linq;

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

			var easy = new online_judge.leetcode.easy.Problem20();
			var medium = new online_judge.leetcode.medium.Problem138();
			var hard = new online_judge.leetcode.hard.Problem480();
			var explore = new online_judge.leetcode.explore.RecursionII();

            /*
			 * ["MedianFinder","addNum","findMedian","addNum","findMedian","addNum","findMedian","addNum","findMedian","addNum","findMedian"]
[[],[-1],[],[-2],[],[-3],[],[-4],[],[-5],[]]
			 */


            /*
            var ret = medium.GetMinIndex2(new List<int> { 1 }, 3);

            ret = medium.GetMinIndex2(new List<int> { 1, 2, 2, 3, 5 }, 4);
            ret = medium.GetMinIndex2(new List<int> { 1, 2, 2, 3, 5 }, 2);
            ret = medium.GetMinIndex2(new List<int> { 1, 2, 2, 3, 5 }, 3);
            ret = medium.GetMinIndex2(new List<int> { 1, 2, 2, 3, 5 }, 5);
            ret = medium.GetMinIndex2(new List<int> { 1, 4 }, 3);
            ret = medium.GetMinIndex2(new List<int> { 1, 4 }, 5);
            ret = medium.GetMinIndex2(new List<int> { 1, 4, 5 }, 4);
            */

            //["TimeMap","set","set","get","set","get","get"]
            //[[],["a","bar",1],["x","b",3],["b",3],["foo","bar2",4],["foo",4],["foo",5]]

            /*
            medium.Set("ctondw", "ztpearaw", 1);
            medium.Set("vrobykydll", "hwliiq", 2);
            medium.Set("gszaw", "ztpearaw", 3);
            medium.Set("ctondw", "gszaw", 4);

            var ret2 = medium.Get("gszaw", 5);
            ret2 = medium.Get("ctondw", 6);
            ret2 = medium.Get("ctondw", 7);
            ret2 = medium.Get("gszaw", 8);
            ret2 = medium.Get("vrobykydll", 9);
            ret2 = medium.Get("ctondw", 10);
            medium.Set("vrobykydll", "kcvcjzzwx", 11);
            ret2 = medium.Get("vrobykydll", 12);
            ret2 = medium.Get("ctondw", 13);
			*/
            //["TimeMap","set","set","set","set","get","get","get","get","get","get","set","get","get","get","set","set","set","set","get","get"]
            //["ctondw",7],["gszaw",8],["vrobykydll",9],["ctondw",10],["vrobykydll","kcvcjzzwx",11],["vrobykydll",12],["ctondw",13],["vrobykydll",14],["ztpearaw","zondoubtib",15],["kcvcjzzwx","hwliiq",16],["wtgbfvg","vrobykydll",17],["hwliiq","gzsiivks",18],["kcvcjzzwx",19],["ztpearaw",20]]
            /*
			medium.WordBreak("leetcode", new List<string> { "leet", "code" });
			medium.WordBreak("applepenapple", new List<string> { "apple", "pen" });
			medium.WordBreak("catsandog", new List<string> { "cats", "dog", "sand", "and", "cat" });
			*/
            
            //Node node7 = new Node(7, null, null, null);
			//Node node6 = new Node(15, null, null, null);
			//Node node5 = new Node(5, null, null, null);
			Node node4 = new Node(1);
			Node node3 = new Node(10);
			Node node2 = new Node(11);
			Node node1 = new Node(13);
			Node head = new Node(7);

			head.next = node1;
			head.random = null;

			node1.next = node2;
			node1.random = head;

			node2.next = node3;
			node2.random = node4;

			node3.next = node4;
			node3.random = node2;

			node4.next = null;
			node4.random = head;

            medium.CopyRandomList(head);


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

            ListNode listnode61 = new ListNode(9, null);
            ListNode listnode6 = new ListNode(9, listnode61);

			ListNode listnode5 = new ListNode(9, listnode6);
			ListNode listnode4 = new ListNode(9, listnode5);

            // [1,0,0,0,0,   0,0,0,0,0   ,0,0,0,0,0   ,0,0,0,0,0   ,0,0,0,0,0   ,0,0,0,0,0,1]
            // [5,6,4]
			ListNode listnode999 = new ListNode(1, null);
            ListNode listnode25 = new ListNode(0, listnode999);
            ListNode listnode24 = new ListNode(0, listnode25);
            ListNode listnode23 = new ListNode(0, listnode24);
            ListNode listnode22 = new ListNode(0, listnode23);
            ListNode listnode21 = new ListNode(0, listnode22);
            ListNode listnode20 = new ListNode(0, listnode21);
            ListNode listnode19 = new ListNode(0, listnode20);
            ListNode listnode18 = new ListNode(0, listnode19);
            ListNode listnode17 = new ListNode(0, listnode18);
            ListNode listnode16 = new ListNode(0, listnode17);

            ListNode listnode15 = new ListNode(8, null);
            ListNode listnode14 = new ListNode(7, listnode15);
            ListNode listnode13 = new ListNode(6, listnode14);
            ListNode listnode12 = new ListNode(5, null);

            ListNode listnode11 = new ListNode(4, listnode12);
            ListNode listnode2 = new ListNode(3, listnode11);
            ListNode listnode1 = new ListNode(2, listnode2);
            ListNode listhead = new ListNode(1, listnode1);
			
            //
			
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
