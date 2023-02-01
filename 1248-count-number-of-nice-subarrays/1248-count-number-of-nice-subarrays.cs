public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        Dictionary<int, int> dic = new Dictionary<int, int>{[0] = 1};
        int ret = 0, sum = 0;
        
        for(int i = 0; i < nums.Length; i++){
            sum += nums[i]%2;
            ret += dic.GetValueOrDefault(sum-k);
            dic[sum] = dic.GetValueOrDefault(sum) + 1;
        }
        return ret;
    }
}