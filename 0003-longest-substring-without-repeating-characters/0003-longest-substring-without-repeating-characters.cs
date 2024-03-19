public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s == null || s == string.Empty) {
            return 0;
        }
        HashSet<int> set = new HashSet<int>();
        int ret = 0, left=0, right=0;
        
        while(right < s.Length)
        {
            if(!set.Contains(s[right]))
            {
                set.Add(s[right]);
                right++;
                ret = Math.Max(ret, right-left);
            } else {
                set.Remove(s[left]);
                left++;
            }
        }
        return ret;

    }
}
