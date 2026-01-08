public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int[] res = new int[nums.Length * 2];
        Array.Copy(nums, 0, res, 0, nums.Length);
        Array.Copy(nums, 0, res, nums.Length, nums.Length);
        return res;
    }
}