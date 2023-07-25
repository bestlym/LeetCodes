public class Solution {
    public void ReverseString(char[] s) {
        var left = 0;
        var right = s.Length-1;
        
        while(right > left){
            var tmpLeft = s[right];
            var tmpRight = s[left];
            
            s[left] = tmpLeft;
            s[right] = tmpRight;
            
            left++;
            right--;
        }
        
        //return s;
    }
}