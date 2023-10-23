public class Solution {
    public int FirstUniqChar(string s) {
        var dic = new Dictionary<char, int>();
        
        foreach(char c in s)
        {
            if(dic.ContainsKey(c)) dic[c] = dic[c] + 1;
            else dic.Add(c, 1);
        }
        
        for(int i=0; i < s.Length; i++)
        {
            if(dic[s[i]] == 1) return i;
        }
        
        return -1;
    }
}