public class MyCalendar {
    List<int[]> calendar;

    public MyCalendar() {
        calendar = new ();
    }
    
    public bool Book(int start, int end) {
        foreach(var book in calendar){
            if(Math.Max(book[0], start) < Math.Min(book[1], end))
                return false;            
        }
        calendar.Add(new int[] {start, end});
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */