public class Solution {
    public int[] SortArrayByParity(int[] nums) {

        int pointer = 0;
        for(int i=0; i < nums.Length; i++){
            if(nums[i]%2 == 0){
                var temp = nums[pointer];
                nums[pointer] = nums[i];
                nums[i] = temp;
                pointer++;
            }
        }
        return nums;
    }
}