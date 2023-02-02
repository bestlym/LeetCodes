public class Solution {
    public int MaximumPopulation(int[][] logs) {
        var births = new int[logs.Length];
        var deaths = new int[logs.Length];
        
        for(int i = 0; i < logs.Length; i++){
            births[i] = logs[i][0];
            deaths[i] = logs[i][1];
        }
        
        Array.Sort(births);
        Array.Sort(deaths);
        
        int currPop = 0;
        int deathIdx = 0;
        int maxPop = 0;
        int maxYear = 0;
        
        for(int i = 0, j =0; i < births.Length; i++){
            currPop++;
            while (deaths[deathIdx] <= births[i]){
                currPop--;
                deathIdx++;
            }
            if(currPop > maxPop){
                maxPop = currPop;
                maxYear = births[i];
            }
        }
        
        return maxYear;
    }
}