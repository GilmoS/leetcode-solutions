public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        string pattern ; 
        var sb = new StringBuilder();
        int lim = s.Length/2;
        for(int i = 1 ; i <=lim ;i++)
        {
           pattern = s.Substring(0,i);
           sb.Clear();
            while(sb.Length < s.Length){
                sb.Append(pattern);
            }
            if(sb.ToString() == s){
                return true;
            }
        }
        return false;
       
    }
}