public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int currSum = 0;
        int left = 0, right = 0;
        int ret = int.MinValue;
        
        while(right < nums.Length)
        {
            currSum += nums[right];
            right++;
            
            if(right-left > k)
            {
                currSum -= nums[left];
                left++;
            }
            
            if(right-left == k)
                ret = Math.Max(ret, currSum);
        }
        
        return (double)ret/k;
    }
}