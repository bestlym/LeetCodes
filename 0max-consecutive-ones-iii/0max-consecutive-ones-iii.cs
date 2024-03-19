public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int maxLength = 0, left = 0, zeroCnt = 0;
        for(int right=0; right < nums.Length; right++)
        {
            if(nums[right] == 0) zeroCnt++;
            
            while(zeroCnt > k)
            {
                if(nums[left] == 0) zeroCnt--;
                left++;
            }
            maxLength = Math.Max(maxLength, right-left+1);
        }
        
        return maxLength;
    }
}