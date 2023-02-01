public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        HashSet<char> hs = new HashSet<char>();
        int res = 0;
        
        foreach(var j in jewels){
            hs.Add(j);
        }
        
        foreach(var s in stones){
            if(hs.Contains(s)) res++;
        }
        
        return res;
    }
}