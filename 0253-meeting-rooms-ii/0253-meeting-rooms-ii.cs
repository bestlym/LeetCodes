public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        int intLen = intervals.Length;
        int res = 0;
        
        int[] start = new int[intLen];
        int[] end = new int[intLen];

        for(int i = 0; i < intLen; i++)
        {
            start[i] = intervals[i][0];
            end[i] = intervals[i][1];
        }
        
        Array.Sort(start);
        Array.Sort(end);  //nlogn

        for(int i=0, j=0; i < intLen; i++)
        {
            if(start[i] < end[j]){
                res++;
            }else {
                j++;
            }
        }
        return res;
    }
}