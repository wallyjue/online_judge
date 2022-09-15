using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.hard
{
    internal class Problem2402
    {
        public int MostBooked(int n, int[][] meetings)
        {
            Array.Sort(meetings, this.Compare);
            long ret = -1;
            long[] lastEndtimes = new long[n];
            long[] bookedTimes = new long[n];
            for(int meetingCnt = 0; meetingCnt < meetings.Length; meetingCnt++)
            {
                bool hasEmptyRoom = false;
                long min = Int64.MaxValue;
                int minRoomNum = 0;
                for (int roomCnt = 0; roomCnt < n;roomCnt++)
                {
                    if (lastEndtimes[roomCnt] < min)
                    {
                        min = lastEndtimes[roomCnt];
                        minRoomNum = roomCnt;
                    }

                    if (lastEndtimes[roomCnt] <= (long)meetings[meetingCnt][0])
                    {
                        bookedTimes[roomCnt]++;
                        lastEndtimes[roomCnt] = meetings[meetingCnt][1];
                        hasEmptyRoom = true;
                        Console.WriteLine("meeting {0}: room {1}, bookedTime {2}", meetingCnt, roomCnt, bookedTimes[roomCnt]);
                        break;
                    }
                }

                if (!hasEmptyRoom)
                {
                    lastEndtimes[minRoomNum] = lastEndtimes[minRoomNum] + meetings[meetingCnt][1] - meetings[meetingCnt][0];
                    bookedTimes[minRoomNum]++;
                    Console.WriteLine("meeting {0}: room {1} ends at {2}, bookedTime {3}, length {4}", 
                           meetingCnt, minRoomNum, lastEndtimes[minRoomNum], bookedTimes[minRoomNum], meetings[meetingCnt][1] - meetings[meetingCnt][0]);
                }
            }

            long bookedTime = -1;
            for (int roomCnt = 0; roomCnt < n; roomCnt++)
            {
                Console.WriteLine("room {0}: {1}", roomCnt, bookedTimes[roomCnt]);
                if (bookedTimes[roomCnt] > bookedTime)
                {
                    ret = roomCnt;
                    bookedTime = bookedTimes[roomCnt];
                }
            }

            return (int)ret;
        }

        private int Compare(int[] a, int[] b)
        {
            return a[0] == b[0] ? a[1] - b[1] : a[0] - b[0];
        }
    }
}
