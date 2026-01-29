public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        int x , y ;
        foreach(int stone in stones)
        {
            pq.Enqueue(stone, -stone);
        }
        while(pq.Count > 1)
        {
            x = pq.Dequeue();
            y = pq.Dequeue();

            if(x!=y){
               pq.Enqueue((x-y),-(x-y)); 
            }
        }
    
        if(pq.Count==0)
        {
            return 0; 
        }
        else{
            return pq.Peek();
        }
    }
}