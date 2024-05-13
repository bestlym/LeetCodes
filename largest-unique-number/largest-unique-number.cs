public class Solution {
    public int LargestUniqueNumber(int[] nums) {
        int ret = -1;        
        if(nums.Length == 0 || nums == null) return ret;
        
        SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
        
        foreach(var n in nums){
            dic[n] = dic.GetValueOrDefault(n, 0) + 1;            
        }
        
        foreach(var d in dic){
            if(d.Value == 1){
                ret = Math.Max(ret, d.Key);
            }
        }
        
        int ret2 = dic.Where(w=>w.Value == 1).OrderBy(o=>o.Key).Select(s=>s.Key).LastOrDefault(-1);
        //return ret;
        return ret2;
    }
}