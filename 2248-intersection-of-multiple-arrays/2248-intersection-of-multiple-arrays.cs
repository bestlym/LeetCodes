public class Solution {
    public IList<int> Intersection(int[][] nums) {

        Dictionary<int, int> dic = new Dictionary<int, int>();
        var ret = new List<int>();
        
        for(int i = 0; i < nums[0].Length; i++){
            bool isCnt = true;
            
            dic.Add(nums[0][i], 1);
            
            for(int j = 1; j < nums.Length; j++)
            {
                if(!nums[j].Contains(nums[0][i])) isCnt = false;
            }
            if(isCnt) ret.Add(nums[0][i]);                
        }
        
        ret.Sort();
        
        return ret;
    }
}