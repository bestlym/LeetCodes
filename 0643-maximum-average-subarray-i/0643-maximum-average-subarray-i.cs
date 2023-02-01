public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        if(nums == null) return 0.00;
        
        int left = 0, right = 0, currSum = 0, maxSum = Int32.MinValue;
        while(right < nums.Length){
            currSum += nums[right];
            right++;
                
            if(right - k > 0){
                currSum -= nums[left];
                left++;
            }
            
            if(right - left == k){
                maxSum = Math.Max(maxSum, currSum);
            }
                
        }
        
        return (double)maxSum / k;
    }
}