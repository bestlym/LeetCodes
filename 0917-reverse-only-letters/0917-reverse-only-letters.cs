public class Solution {
    public string ReverseOnlyLetters(string s) {
        char[] c = s.ToCharArray();
        int left = 0, right = s.Length - 1;
        
        while(left < right){
            if(IsLetter(s[left]) && IsLetter(s[right])){
                (c[left], c[right]) = (c[right], c[left]);
                left++;
                right--;
            } else {
                if(!IsLetter(c[left])) left++;
                if(!IsLetter(c[right])) right--;    
            }            
        }
        
        return new String(c);
    }
    
    private bool IsLetter(char c){
        return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
    }
}