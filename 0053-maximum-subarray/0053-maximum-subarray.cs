public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums.Length == 0) return 0;
        if(nums.Length == 1) return nums[0];
        
        int ret = int.MinValue;
        int sum = 0;
        
        for(int i=0; i < nums.Length; i++){
            sum += nums[i];
            ret = Math.Max(sum, ret);
            if(sum < 0) sum = 0;
        }
        return ret;
    }
}