public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int right = 0, left = 0, zeroCnt = 0, ret=0;
        while(right < nums.Length)
        {
            if(nums[right] == 0){
                zeroCnt++;
                while(zeroCnt > 1){
                    if(nums[left] == 0)
                        zeroCnt--;
                    left++;
                }
                    
            }
            
            ret = Math.Max(ret, right-left+1);
            right++;
        }
        return ret;
    }
}