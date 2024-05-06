public class Solution {
    public int WaysToSplitArray(int[] nums) {
        var ret = 0;
        long sum=0, currSum=0;        
        
        foreach(var n in nums)
        {
            sum += n;
        }        
        
        for(int i=0; i < nums.Length-1; i++)
        {
            currSum+=nums[i];
            if(currSum >= sum-currSum) ret++;
        }
        
        return ret;
    }
}