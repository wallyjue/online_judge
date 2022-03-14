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
            int round = 1, pow = 2;
            for (int index = nums.Length / 2; index >= 0 && index < nums.Length && pow > 0;)
            {
                if (nums[index] == target)
                {
                    return index;
                }
                round++;
                pow *= 2;
                if (nums[index] > target)
                {
                    index -= pow > nums.Length ? 1 : nums.Length / pow;
                }
                else
                {
                    index += pow > nums.Length ? 1 : nums.Length / pow;
                }
            }
            return -1;

        }
    }
}
