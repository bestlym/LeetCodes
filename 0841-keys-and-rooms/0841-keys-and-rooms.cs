public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        if(rooms.Count == 0) return false;
        return DfsForReachableRooms(rooms, new HashSet<int>(), 0) == rooms.Count;
    }
    
    int DfsForReachableRooms(IList<IList<int>> rooms, HashSet<int> seen, int curRoom)
    {
        if(seen.Contains(curRoom)) return 0;
        seen.Add(curRoom);
        foreach(var roomKey in rooms[curRoom])
            DfsForReachableRooms(rooms, seen, roomKey);
        return seen.Count;
    }
}