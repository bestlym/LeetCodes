public class Solution {
    public int[] SortedSquares(int[] nums) {
        int left = 0, right = nums.Length-1;
        int[] ret = new int[nums.Length];
        
        for(int i = nums.Length-1; i >= 0; i--){
            if(Math.Abs(nums[right]) > Math.Abs(nums[left]))
            {
                ret[i] = nums[right] * nums[right];
                right--;
            } else {
                ret[i] = nums[left] * nums[left];
                left++;
            }
        }
        return ret;
    }
}
