public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        var ret = new int[nums.Length];
        int left = 0; 
        int right = nums.Length-1;
        
        for(int i=nums.Length-1; i >= 0; i--)
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
