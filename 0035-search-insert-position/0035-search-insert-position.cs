public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0, right = nums.Length - 1, mid = 0;
        
        if(nums == null || nums.Length == 0) return -1;
        
        while(left <= right){
            mid = (right-left)/2 + left;
            
            if(nums[mid] == target) return mid;
            else if(nums[mid] < target) left = mid + 1;
            else right = mid-1;
        }
        
        return left;
    }
}