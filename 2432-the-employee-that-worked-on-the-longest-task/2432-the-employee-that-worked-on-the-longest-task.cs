public class Solution {
    public int HardestWorker(int n, int[][] logs) {
        var dic = new Dictionary<int, int>();
        int maxVal = logs[0][1]-0;
        int ret = logs[0][0];
        //dic[logs[0][1]-0] = logs[0][0];
        
        for(int i=1; i < logs.Length; i++)
        {
            int currCal = logs[i][1]-logs[i-1][1];
            int currId = logs[i][0];
            //if(maxVal >= currCal) continue;
            //dic[currCal] = logs[i][0];
            if(maxVal < currCal || (maxVal == currCal && currId < ret))
                ret = currId;

            maxVal = Math.Max(maxVal, currCal);            
        }
        
        //return dic[maxVal];
        return ret;
    }
}