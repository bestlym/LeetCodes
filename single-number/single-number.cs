public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        
        foreach(int n in nums){
            if(dic.ContainsKey(n)) dic[n]++;
            else dic[n] = 1;
        }
        
        return dic.Where(p=>p.Value == 1).First().Key;
    }
}