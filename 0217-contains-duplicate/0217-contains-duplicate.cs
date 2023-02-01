public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        
        foreach(var n in nums){
            if(!hs.Add(n)) return true;
        }
        
        return false;
    }
}