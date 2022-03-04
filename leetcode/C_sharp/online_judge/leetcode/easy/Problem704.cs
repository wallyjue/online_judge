using System.Text;

namespace online_judge.leetcode.easy
{
    public class Problem704
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length <= 2)
            {
                if (nums[0] == target)
                {
                    return 0;
                }
                else if (nums.Length == 2 && nums[1] == target)
                {
                    return 1;
                }

                return -1;
            }


            int index = nums.Length / 2;
            for (var cnt = 0; cnt < nums.Length; cnt++)
            {
                if( target == nums[index])
                {
                    return index;
                }

                int diff = index / 2;
                
                if (diff < 1)
                {
                    diff = 1;
                }

                if (target > nums[index])
                {
                    index += diff;
                    if (target == nums[index])
                    {
                        return index;
                    }
                    else if (index > nums.Length)
                    {
                        return -1;
                    }
                }
                else
                {
                    index -= diff;
                    if (target == nums[index])
                    {
                        return index;
                    }
                    else if (index < 0)
                    {
                        return -1;
                    }
                }

            }
            return -1;

        }
    }
}
