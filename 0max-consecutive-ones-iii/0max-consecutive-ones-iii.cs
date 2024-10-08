public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int ret = 0;
        int zeroCount = 0;
        int left = 0;
        
        for(int right = 0; right < nums.Length; right++)
        {
            if(nums[right] == 0) zeroCount++;
            
            while(zeroCount > k)
            {
                if(nums[left] == 0) zeroCount--;
                left++;
            }
            
            ret = Math.Max(ret, right-left+1);
        }
        
        return ret;
        
    }
}