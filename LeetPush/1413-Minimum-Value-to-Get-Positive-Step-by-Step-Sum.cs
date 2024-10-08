public class Solution {
    public int MinStartValue(int[] nums) {        
        int minVal = 0;
        int sum = 0;
        
        foreach(int n in nums)
        {
            sum += n;
            minVal = Math.Min(minVal, sum);
        }
        
        return 1-minVal;
    }
}