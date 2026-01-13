public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int dup = -1;
        int missing = -1;


        for (int i = 0; i < nums.Length; i++)
        {
            int x = Math.Abs(nums[i]);
            int idx = x - 1;

            if (nums[idx] < 0)
                dup = x;
            else
                nums[idx] = -nums[idx];
        }


        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                missing = i + 1;
                break;
            }
        }

        return new int[] { dup, missing };
    }
}