public class Solution {
    public int WaysToSplitArray(int[] nums) {
        int ret = 0;
        long sum = 0, left = 0;
        
        foreach(var n in nums){
            sum += n;
        }
        
        for(int i=0; i < nums.Length-1; i++){
            left += nums[i];
            long right = sum - left;
            if(left >= right) ret++;
        }
        return ret;
    }
}