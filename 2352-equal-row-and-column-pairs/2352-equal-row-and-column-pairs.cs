public class Solution {
    public int EqualPairs(int[][] grid) {
        var dic = new Dictionary<string, int>();
        int ret = 0;
        
        foreach(int[] g in grid)
        {
            var arrStr = string.Join(" ", g);
            if(!dic.TryAdd(arrStr, 1)) dic[arrStr]++;
            //dic[arrStr] = dic.GetValueOrDefault(arrStr, 0)+1;            
            //if(!dic.ContainsKey(arrStr)) dic.Add(arrSrt, 0);                
            //dic[arrStr]++;            
        }
        
        for(int i=0; i < grid.Length; i++)
        {
            int[] colArr = new int[grid.Length];
            for(int j=0; j < grid.Length; j++)
            {
                colArr[j] = grid[j][i];
            }
            ret += dic.GetValueOrDefault(string.Join(" ", colArr), 0);
        }        
        return ret;        
    }
}