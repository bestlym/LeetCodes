public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle.Length > haystack.Length) return -1;
        
        for(int i=0; i <= haystack.Length-needle.Length; i++)
        {
            int j=0;
            for(; j < needle.Length; j++)
            {
                if(haystack[j+i] == needle[j]) continue;
                break;
            }
            if(j == needle.Length) return i;                
        }
        
        return -1;
    }
}