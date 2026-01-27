public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int time = 0;
        int i = 0;
        while (tickets[k]!=0){
           if(tickets[i]==0){
            i = (i+1) % (tickets.Length);
           }
           else{
           tickets[i]--;
           i = (i+1) % (tickets.Length);
           time++;
           }
        }
        return time;
    }
}