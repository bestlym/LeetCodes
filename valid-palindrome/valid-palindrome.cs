public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length-1;
        
        while(left < right)
        {
            if(!Char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }
            
            if(!Char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }
            
            if(Char.ToLower(s[left]) != Char.ToLower(s[right])) return false;
            left++;
            right--;            
        }
        
        return true;
        
        
    }
}