public class Solution {
    public char RepeatedCharacter(string s) {
        var hs = new HashSet<char>();
        
        foreach(char c in s)
        {
            if(!hs.Add(c))
            {
                return c;
            }
        }
        
        return ' ';
        
    }
}