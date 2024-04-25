public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        int ret = 0;
        int intLen = intervals.Length;
        
        int[] start = new int[intLen];
        int[] end = new int[intLen];
        
        for(int i =0; i < intLen; i++)
        {
            start[i] = intervals[i][0];
            end[i] = intervals[i][1];
        }
        
        Array.Sort(start);
        Array.Sort(end);
            
        
        for(int i=0, j=0; i < intLen; i++)
        {
            if(end[j] > start[i]) ret++;
            else j++;            
        }
        
        return ret;
    }
}