public class Solution {
    public int MissingNumber(int[] nums) {
        int sum = nums.Length * (nums.Length+1) / 2;
        
        foreach(int n in nums)
        {
            sum -= n;
        }
        
        return sum;
    }    
}