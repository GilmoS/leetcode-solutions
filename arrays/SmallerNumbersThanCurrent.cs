public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] res = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (j != i && nums[j] < nums[i])
                {
                    res[i]++;
                }
            }
        }
        return res;
    }

}