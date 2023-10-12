public class Solution {
    public void MoveZeroes(int[] nums) {
        int cnt = 0;
        
        for(int i=0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                cnt++;
            } else {
                nums[i-cnt] = nums[i];
            }
        }
        
        for(int i=nums.Length-cnt; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}