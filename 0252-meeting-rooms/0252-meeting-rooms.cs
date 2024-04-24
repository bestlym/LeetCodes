public class Solution
{
    public bool CanAttendMeetings(int[][] intervals)
    {
        Array.Sort(intervals, (interval1, interval2) => interval1[0].CompareTo(interval2[0]));
       
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < intervals[i - 1][1])
                return false;
        }

        return true;
    }
}