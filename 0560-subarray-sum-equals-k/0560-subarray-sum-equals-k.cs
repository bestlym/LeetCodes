public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int ret = 0, curr = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>{[0] = 1};
        
        for(int i = 0; i < nums.Length; i++){
            curr += nums[i];
            ret += dic.GetValueOrDefault(curr-k, 0);
            dic[curr] = dic.GetValueOrDefault(curr) + 1;
        }        
        return ret;
    }
}