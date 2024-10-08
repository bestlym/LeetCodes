public class Solution {
    public int WaysToSplitArray(int[] nums) {
        int ret = 0;
        long left = 0;
        long sum = 0;

        foreach(int n in nums)
        {
            sum+=n;
        }

        for(int i=0; i < nums.Length-1; i++)
        {
            left += nums[i];
            long right = sum-left;
            if(left >= right) ret++;
        }

        return ret;
    }
}