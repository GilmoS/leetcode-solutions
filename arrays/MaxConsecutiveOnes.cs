public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int curr = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                curr++;
            }
            else
            {
                curr = 0;
            }
            if (curr > max)
            {
                max = curr;
            }

        }
        return max;

    }
}