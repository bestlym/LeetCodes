public class Solution {
    public int[] SortedSquares(int[] nums) {
        int numsLength = nums.Length;
        
        int left = 0;
        int right = numsLength - 1;
        
        
        int[] ret = new int[numsLength];
        
        for(int i = right; i >= 0; i--)
        {
            if(Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                ret[i] = nums[left] * nums[left];
                left++;
                
            } else {
                ret[i] = nums[right] * nums[right];
                right--;
            }
        }
        
        return ret;
        
    }
}
