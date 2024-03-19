public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length-1;

        while(left < right)
        {
            if(!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }
            if(!char.IsLetterOrDigit(s[right]))
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