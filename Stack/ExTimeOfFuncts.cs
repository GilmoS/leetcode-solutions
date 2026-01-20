public class Solution
{
    public int[] ExclusiveTime(int n, IList<string> logs)
    {
        int[] res = new int[n];
        Stack<int> st = new Stack<int>();
        int pervTime = 0;
        foreach (string log in logs)
        {
            string[] parts = log.Split(":");
            int funcID = int.Parse(parts[0]);
            string type = parts[1];
            int time = int.Parse(parts[2]);

            if (type == "start")
            {
                if (st.Count > 0)
                {
                    res[st.Peek()] += time - pervTime;
                }
                st.Push(funcID);
                pervTime = time;

            }
            else
            {
                res[st.Pop()] += time - pervTime + 1;
                pervTime = time + 1;
            }
        }
        return res;
    }


}