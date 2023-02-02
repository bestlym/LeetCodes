public class Solution {
    public bool CheckIfPangram(string sentence) {
        if(sentence.Length < 26) return false;
        
        HashSet<char> hs = new HashSet<char>();
        
        foreach(char s in sentence){
            hs.Add(s);
        }
        
        return hs.Count == 26;
        
    }
}