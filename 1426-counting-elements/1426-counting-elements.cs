public class Solution {
    public int CountElements(int[] arr) {
        HashSet<int> hs = new HashSet<int>(arr);
        int ret = 0;
        
        for(int i = 0; i < arr.Length; i++){
            if(hs.Contains(arr[i] + 1)) ret++;
        }
        
        return ret;        
    }
}