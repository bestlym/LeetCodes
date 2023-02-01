public class Solution {
    public int Search(int[] nums, int target) {
        if(nums == null || nums.Length == 0)
            return -1;

        int left = 0, right = nums.Length - 1;

        while(left <= right) {
            Console.WriteLine("left: " + left);
            Console.WriteLine("right: " + right);

            int mid = (right-left) /2 + left;
            
            Console.WriteLine("Mid: " + mid);
            
            if(nums[mid] == target){
                return mid;
            } else if(nums[mid] < target){
                left = mid + 1;
            } else {
                right = mid - 1;
            }
            Console.WriteLine("-------------------");
        }

        return -1;
    }
}



