public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int curr = 0;
        int left = 0, right = 0;
        int ret = int.MinValue;
        
        while(right < nums.Length)
        {
            curr += nums[right];
            right++;
            
            if(right - left > k)
            {
                curr -= nums[left];
                left++;
            }
            
            if(right-left == k)
            {
                ret = Math.Max(ret, curr);
            }
            
            
        }
        
        return (double)ret/k;
    }
}