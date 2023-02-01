public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int maxLength = 0, left = 0, zeroCnt = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0) zeroCnt++;
            
            while(zeroCnt > k){
                if(nums[left] == 0) zeroCnt--;
                left++;                
            }
            maxLength = Math.Max(maxLength, i-left + 1);
        }        
        return maxLength;
        
    }
}