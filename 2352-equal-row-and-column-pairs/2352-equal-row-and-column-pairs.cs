public class Solution {
    public int EqualPairs(int[][] grid) {
        int ret = 0;
        
        Dictionary<string, int> dic = new Dictionary<string, int>();
        string compStr = string.Empty;
        
        for(int i=0; i < grid.Length; i++){
            var addStr =  String.Join(" ", grid[i]);
            if(!dic.TryAdd(addStr, 1)) dic[addStr]++;
        }        
        
        for(int d=0; d < grid.Length; d++){
            StringBuilder sb = new StringBuilder();
            for(int j=0; j < grid.Length; j++)
            {   
                var addStr2 = (j != grid.Length - 1) ? (grid[j][d] + " ").ToString() : grid[j][d].ToString();
                sb.Append(addStr2);
            }
            compStr = sb.ToString();        

            if(dic.ContainsKey(compStr)) ret += dic[compStr];
        }        
        
        return ret;
    }
}