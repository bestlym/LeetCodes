public class Solution {
    public int HardestWorker(int n, int[][] logs) {
        int maxVal = logs[0][1]-0;
        int ret = logs[0][0];
        
        for(int i=1; i < logs.Length; i++)
        {
            int currCal = logs[i][1]-logs[i-1][1];
            int currId = logs[i][0];

            if(maxVal < currCal || (maxVal == currCal && currId < ret))
                ret = currId;

            maxVal = Math.Max(maxVal, currCal);            
        }
        
        return ret;
    }
}