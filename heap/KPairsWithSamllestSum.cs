public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var res = new List<IList<int>>();
        var pq = new PriorityQueue<(int i, int j), int>();
        int lim = Math.Min(nums1.Length,k);

        for(int i=0 ; i<lim ; i++){
            pq.Enqueue((i, 0), nums1[i] + nums2[0]);
        }

        while (k > 0 && pq.Count > 0)
    {
        var cur = pq.Dequeue();
        int i = cur.i;
        int j = cur.j;

        res.Add(new List<int> { nums1[i], nums2[j] });
        k--;

        if (j + 1 < nums2.Length)
            pq.Enqueue((i, j + 1), nums1[i] + nums2[j + 1]);
    }

        return res;

    }
}