public class Solution {
    public void Rotate(int[] nums, int k) {
        if(nums.Length < 2 || nums == null) return;
        
        k %= nums.Length;
        
        Reverse(nums, 0, nums.Length-1);
        Reverse(nums, 0, k-1);
        Reverse(nums, k, nums.Length-1);
    }
    
    public void Reverse(int[] nums, int left, int right)
    {
        while(left < right)
        {
            var temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++;
            right--;
        }        
    }
}