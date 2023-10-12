public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();
        
        Array.Sort(sArray);
        Array.Sort(tArray);
        
        s = new string(sArray); t = new string(tArray);        
        
        return (s == t);
        
    }
}