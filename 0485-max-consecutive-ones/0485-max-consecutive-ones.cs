public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int ret = 0;
        int curr = 0;
        
        foreach(int n in nums)
        {
            if(n == 0) {
                curr = 0;
                continue;
            }
            
            curr++;
            ret = Math.Max(ret, curr);
        }
        
        return ret;
    }
}