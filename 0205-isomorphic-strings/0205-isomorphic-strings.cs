public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var map1 = new Dictionary<char, char>();
        var map2 = new Dictionary<char, char>();
        
        for (int i = 0; i < s.Length; ++i)
        {
            map1.TryAdd(s[i], t[i]);
            map2.TryAdd(t[i], s[i]);
            
            if (map1[s[i]] != t[i] || map2[t[i]] != s[i]) return false;
        }
        
        return true;
    }
}