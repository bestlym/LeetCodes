public class Solution {
    public void ReverseString(char[] s) {
        var left = 0;
        var right = s.Length-1;
        
        while(left < right)
        {
            (s[left], s[right]) = (s[right], s[left]);
            //var temp = s[left];
            //s[left] = s[right];
            //s[right] = temp;
            
            left++;
            right--;
        }        
    }
}