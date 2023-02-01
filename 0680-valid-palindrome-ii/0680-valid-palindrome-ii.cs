public class Solution {
    public bool ValidPalindrome(string s) 
    {    
        int left = 0;
        int right = s.Length - 1;
        
        while(left < right) {
            if(s[left] == s[right]){
                left++;
                right--;
            } else {
                return IsPalidrome(left+1, right, s) || IsPalidrome(left, right-1, s);
            }            
        }        
        return true;
    }
    
    private bool IsPalidrome(int left, int right, string s){
        while(left < right){
            if(s[left] == s[right]){
                left++;
                right--;
            } else {
                return false;
            }
        }
        return true;
    }
}