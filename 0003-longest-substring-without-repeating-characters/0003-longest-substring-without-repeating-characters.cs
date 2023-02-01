public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s == null || s == string.Empty) {
            return 0;
        }
        
        int maxVal = 0;
        int j = 0;
        int i = 0;
        
        HashSet<char> sett = new HashSet<char>();
        
        while(j < s.Length){
            if(!sett.Contains(s[j])){
                sett.Add(s[j]);
                j++;
                maxVal = Math.Max(maxVal, j-i);
            } else {
                sett.Remove(s[i]);
                i++;
            }
        }
        return maxVal;
    }
}
