using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem79
    {
        private string word = string.Empty;
        List<Tuple<int, int>> starts = new List<Tuple<int, int>>();
        char[][] board;
        public bool Exist(char[][] board, string word)
        {
            bool ret = false;
            this.word = word;
            this.board = board;
            // scan through board for finding the starting points
            for (int x = 0; x < board.Length; x++)
            {
                for (int y = 0; y < board[x].Length; y++)
                {
                    if (board[x][y] == word[0])
                    {
                        this.starts.Add(new Tuple<int, int>(x, y));
                    }
                }
            }

            // backtracking the array from the starting points
            foreach(Tuple<int, int> pair in starts)
            {
                bool[][] visited = new bool[board.Length][];
                for (int x = 0; x < board.Length; x++)
                {
                    visited[x] = new bool[board[x].Length];
                }
                ret |= backtracking(board[pair.Item1][pair.Item2], string.Empty, pair.Item1, pair.Item2, visited);
                if (ret)
                {
                    return true;
                }
            }
            return ret;
        }


        private bool backtracking(char toAdd, string curr, int x, int y, bool[][] visited)
        {
            bool ret = false;
            if (x < 0 || y < 0 || visited[x][y])
            {
                return false;
            }
            
            if (!this.word.StartsWith(curr + toAdd))
            {
                visited[x][y] = false;
                return false;
            }

            if (this.word == curr + toAdd)
            {
                return true;
            }

            visited[x][y] = true;
            curr = curr + toAdd;
            // try [x - 1][y]
            // backtracking
            if (x - 1 >= 0)
            {
                ret |= backtracking(board[x - 1][y], curr, x - 1, y, visited);
            }
            
            // remove [x - 1][y]
            //visited[x-1][y] = true;

            // try [x + 1][y]
            if (x + 1 < board.Length)
            {
                ret |= backtracking(board[x + 1][y], curr, x + 1, y, visited);
            }
            // remove [x + 1][y]

            // try [x][y - 1]
            if (y - 1 >= 0)
            {
                ret |= backtracking(board[x][y - 1], curr, x, y - 1, visited);
            }
            // remove [x][y - 1]

            // try [x][y + 1]
            if (y + 1 < board[0].Length)
            {
                ret |= backtracking(board[x][y + 1], curr, x, y + 1, visited);
            }
            // remove [x][y + 1]
            visited[x][y] = ret;
            return ret;
        }
    }
}
