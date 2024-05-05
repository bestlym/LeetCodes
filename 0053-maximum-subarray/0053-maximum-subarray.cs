public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums.Length == 0) return 0;
        if(nums.Length == 1) return nums[0];
        
        int sum=0, ret=int.MinValue;
        
         foreach(int n in nums)
         {
            sum += n;
            ret = Math.Max(sum, ret);
            if(sum < 0) sum = 0;
        }
        
        return ret;
    }
}