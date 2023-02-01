public class Solution {
    public void ReverseString(char[] s) {        
        ReverStr(s, 0, s.Length-1);
    }
    
    private void ReverStr(char[] s, int i, int j){
        if(i >= j) return;
        var temp = s[i];
        s[i] = s[j];
        s[j] = temp;
        
        ReverStr(s, ++i, --j);
            
    }        
}