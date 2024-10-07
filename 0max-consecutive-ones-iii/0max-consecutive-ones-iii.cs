public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int zeroCnt = 0;
        int ret = 0;
        int left = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0) zeroCnt++;
            
            while(zeroCnt > k)
            {
                if(nums[left] == 0) zeroCnt--;
                left++;
            }
            
            ret = Math.Max(ret, i-left+1);
        }
        
        return ret;
        
    }
}