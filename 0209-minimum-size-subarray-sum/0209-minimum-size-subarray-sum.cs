public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0;
        int sum = 0;
        int minLen = int.MaxValue;

        for (int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];
            while (sum >= target)
            {
                minLen = Math.Min(minLen, right - left + 1);
                sum -= nums[left];
                left++;
            }
        }

        if (minLen == int.MaxValue)
            minLen = 0;

        return minLen;
        
    }
}