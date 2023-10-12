public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0 || nums == null) return 0;
        
        int j = 0;
        
        for(int i=0; i < nums.Length; i++)
        {
            if(i < 1 || nums[i] > nums[i-1])
            {
                nums[j] = nums[i];
                j++;
            }
        }
        
        return j;
    }
}