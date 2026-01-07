public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int[] res = new int[nums.Length * 2];
        for (int i = 0; i < nums.Length * 2; i++)
        {
            res[i] = nums[i % nums.Length];
        }
        return res;
    }
}