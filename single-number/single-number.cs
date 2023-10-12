public class Solution {
    public int SingleNumber(int[] nums) {
        int ret = 0;
        
        foreach(int n in nums){
            ret ^= n;
        }
        return ret;
    }
}