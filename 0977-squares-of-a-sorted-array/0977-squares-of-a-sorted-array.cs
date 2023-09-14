public class Solution {
    public int[] SortedSquares(int[] nums) {
        int numLen = nums.Length;
        
        int left = 0;
        int right = numLen - 1;
        
        int[] ret = new int[numLen];
        
        for(int i = numLen-1; i >= 0; i--){
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
