public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        if (k <= 1) return 0; 
        
        int ret = 0, left=0, curr=1;
        
        for(var i=0; i < nums.Length; i++){
            curr *= nums[i];
            while(left<i && curr >= k)
            {
                curr /= nums[left];
                left++;             
            }
            
            if(curr < k){
                ret += (i-left+1);
            }
            
        }
        
        return ret;
    }
}
