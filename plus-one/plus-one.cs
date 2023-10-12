public class Solution {
    public int[] PlusOne(int[] digits) {
        
        for(int i = digits.Length-1; i > -1; i--)
        {
            if(digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            
            digits[i] = 0;
        }
        int[] ret = new int[digits.Length+1];
        ret[0] = 1;
        return ret;
    }
}