public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] ret = new int[nums.Length];
        ret[0] = nums[0];

        for(int i=1; i < nums.Length; i++)
        {
            ret[i] = ret[i-1] + nums[i];
        }

        return ret;
    }
}