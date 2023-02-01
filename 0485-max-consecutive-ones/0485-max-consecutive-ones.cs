public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxValue = 0;
        int cons = 0;
        for(var i=0; i < nums.Length; i++){
            
            if(nums[i] == 0){                
                cons = 0;
            } else {
                cons++;
                maxValue = Math.Max(maxValue, cons);
            }
            
            
        }
        return maxValue;
    }
}