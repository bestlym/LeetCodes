public class Solution {
    public int PivotIndex(int[] nums) {
        var totalSum = 0;
        int leftSum = 0;
        
        foreach(int n in nums){
            totalSum += n;
        }
        
        for(int i=0; i < nums.Length; i++){
            if(totalSum - (leftSum*2)-nums[i] == 0) return i;
            leftSum += nums[i];
        }
        
        return -1;
    }
}