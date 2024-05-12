public class Solution {
    public bool CheckIfPangram(string sentence) {
        if(sentence.Length < 26) return false;
        
        var hs = new HashSet<char>();
        
        foreach(char c in sentence)
        {
            hs.Add(c);
        }
        
        return hs.Count == 26;
    }
}