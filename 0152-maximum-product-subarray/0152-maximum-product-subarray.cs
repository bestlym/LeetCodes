public class Solution {
    public int MaxProduct(int[] nums) {
        int ret = nums[0];
        int max = 1, min = 1, prevMax = 1;
        
        foreach(int n in nums)
        {
            prevMax = max;
            max = Math.Max(max*n, Math.Max(min*n, n));
            min = Math.Min(prevMax*n, Math.Min(min*n, n));
            ret = Math.Max(max, ret);
            
            Console.WriteLine($" {max}:{min}:{ret}");
        }
        
        return ret;
    }
}