public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int[] pref = new int[2];
        foreach(int s in students ){
            pref[s]++;
        }
        foreach(int sw in sandwiches){
            if(pref[sw] == 0){
                break;
            }
            else{
                pref[sw]--;
            } 
        }
         return pref[0] + pref[1];
    }
}