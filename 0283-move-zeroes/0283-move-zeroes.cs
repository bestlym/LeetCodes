public class Solution {
    public void MoveZeroes(int[] nums) {
        int pointer = 0;
        for(var i=0;i < nums.Length; i++){
            if(nums[i] != 0){
                var temp = nums[pointer];
                nums[pointer] = nums[i];
                nums[i] = temp;     
                pointer++;
            }
        }        
    }
}