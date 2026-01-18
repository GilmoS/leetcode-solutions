public class Solution
{

    public IList<string> BuildArray(int[] target, int n)
    {
        string push = "Push";
        string pop = "Pop";
        List<string> resStack = new List<string>();
        for (int x = 1, i = 0; x <= n && i < target.Length; x++)
        {
            resStack.Add(push);
            if (x == target[i])
            {
                i++;
            }
            else
            {
                resStack.Add(pop);
            }

        }





        return resStack;




    }

}