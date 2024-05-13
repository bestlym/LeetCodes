public class Solution {
    public int LargestUniqueNumber(int[] nums) {        
        Dictionary<int, int> dic = new  Dictionary<int, int>();
        
        foreach(var n in nums){
            dic[n] = dic.GetValueOrDefault(n, 0) + 1;            
        }       

        return dic.Where(w=>w.Value == 1).OrderBy(o=>o.Key).Select(s=>s.Key).LastOrDefault(-1);
    }
}