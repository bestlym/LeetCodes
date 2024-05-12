public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        var dic = new Dictionary<int, int>(){[0]=1};
        int ret=0, curr=0;
        
        foreach(int n in nums)
        {
            curr += n % 2;
            ret += dic.GetValueOrDefault(curr-k, 0);
            dic[curr] = dic.GetValueOrDefault(curr, 0) + 1;
        }        
        return ret;
    }
}