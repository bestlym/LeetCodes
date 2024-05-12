public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int ret = 0, curr = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>{[0] = 1};
        
        foreach(int n in nums){
            curr += n; 
            ret += dic.GetValueOrDefault(curr-k, 0);
            dic[curr] = dic.GetValueOrDefault(curr, 0) + 1;
        }        
        return ret;
    }
}