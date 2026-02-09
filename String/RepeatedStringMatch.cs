public class Solution {
    public int RepeatedStringMatch(string a, string b) {

         if(!b.All(c => a.Contains(c))){
            return -1;
         }
         var sb = new StringBuilder();
         int repeated = 0;
         while(sb.Length < b.Length)
         {
            sb.Append(a);
            repeated++;
         }

         if(sb.ToString().Contains(b)){
            return repeated;
         }

        sb.Append(a);
        repeated++;

        if(sb.ToString().Contains(b)){
            return repeated; 
        }
        return -1;
           

    }     
}