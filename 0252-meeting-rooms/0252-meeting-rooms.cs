public class Solution
{
    public bool CanAttendMeetings(int[][] intervals)
    {
        Array.Sort(intervals, (intervals1, intervals2) => intervals1[0] - intervals2[0]);
        
        for(int i=1; i < intervals.Length; i++)
        {
            if(intervals[i-1][1] > intervals[i][0]) return false;            
        }    
        return true;
    }
}