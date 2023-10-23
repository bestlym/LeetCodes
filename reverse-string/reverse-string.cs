public class Solution {
    public void ReverseString(char[] s) {
        var left = 0;
        var right = s.Length-1;
        
        while(right > left)
        {
            var tempLeft = s[left];
            var tempRight = s[right];
            
            s[left] = tempRight;
            s[right] = tempLeft;
            
            left++;
            right--;
        }                
    }
}