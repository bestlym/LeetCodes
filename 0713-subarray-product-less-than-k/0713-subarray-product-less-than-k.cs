public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        if(k <= 1) return 0;
        
        int cnt = 0;
        int currProd = 1;
        int left = 0;
        
        for(int right=0; right < nums.Length; right++)
        {
            currProd *= nums[right];
            while(currProd >= k)
            {
                currProd /= nums[left];
                left++;
            }
            
            cnt += right-left+1;
            
        }
        
        return cnt;
        
    }
}