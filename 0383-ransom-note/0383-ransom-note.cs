public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        List<char> listM = magazine.ToList();        
        
        foreach(var c in ransomNote){
            if(!listM.Remove(c)) return false;
        }
        
        return true;
        
    }
}