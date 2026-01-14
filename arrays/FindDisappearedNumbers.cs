public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        List<int> res = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int x = Math.Abs(nums[i]);
            int idx = x - 1;

            if (nums[idx] > 0)
            {
                nums[idx] = -nums[idx];
            }

        }


        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                res.Add(i + 1);
            }
        }
        return res;

    }
}