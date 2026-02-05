public class Solution
{
    public string LicenseKeyFormatting(string s, int k)
    {
        if (string.IsNullOrEmpty(s))
            return s;

        var sb = new StringBuilder();
        int count = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            char c = s[i];
            if (c == '-') continue;

            if (count == k)
            {
                sb.Append('-');
                count = 0;
            }

            sb.Append(char.ToUpperInvariant(c));
            count++;
        }

        char[] arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}  