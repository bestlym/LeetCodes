public class Solution {
    public int[] GetAverages(int[] nums, int k) {
        int n = nums.Length;
        var ret = new int[n];
        
        Array.Fill(ret, -1);
        
        int r = (k*2) + 1;        
        long preSum = 0;
        int start = k;
        int end = n-k-1;        
        
        for(int i=0; i < Math.Min(n, r); i++)
        {
            preSum += nums[i];
        }
        
        while(start <= end){           
            ret[start] = (int)(preSum / r);
            if(start+1 <= end){
                preSum = preSum + nums[start+k+1] - nums[start-k];
            }
            start++;            
        }        
        return ret;
    }
}