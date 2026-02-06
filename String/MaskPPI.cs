public class Solution {
    public string MaskPII(string s) {
        var sb = new StringBuilder();
        if(s.Contains('@')){    //its an email
            int indx = s.IndexOf('@');
            string name = s.Substring(0,indx);
            string domain = s.Substring(indx);

            name = name.ToLowerInvariant();
            domain = domain.ToLowerInvariant();
            string result = name[0] + "*****" + name[name.Length - 1];  //add five '*'
            sb.Append(result);
            sb.Append(domain);
        }
        else{  //it a phone number
            string digitsOnly = new string(s.Where(char.IsDigit).ToArray());//remove every chareter that is not a digit 
            int len = digitsOnly.Length;
            string last4 = digitsOnly.Substring(len - 4);
            switch(len)
            {
                case 11:  sb.Append("+*-***-***-");
                            break;
                case 12:  sb.Append("+**-***-***-");
                            break;
                case 13:  sb.Append("+***-***-***-");
                            break;
                default:  sb.Append("***-***-");
                            break;
            };
            sb.Append(last4);

        }

        return sb.ToString();


    }
}