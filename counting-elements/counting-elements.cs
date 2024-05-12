public class Solution {
    public int CountElements(int[] arr) {
        var hs = new HashSet<int>(arr);
        int ret = 0;
        
        foreach(int i in arr)
        {
            if(hs.Contains(i+1)) ret++;
        }
        
        return ret;
    }
}