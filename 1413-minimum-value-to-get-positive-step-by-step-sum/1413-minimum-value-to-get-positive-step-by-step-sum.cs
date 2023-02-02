public class Solution {
    public int MinStartValue(int[] nums) {

        var minVal = 0;
        var sum = 0;
        
        for(int i=0; i < nums.Length; i++){
            sum += nums[i];
            minVal = Math.Min(minVal, sum);
        }
        return 1-minVal;
        
    }
}