public class Solution {
    public bool CheckIfExist(int[] arr) {
        HashSet<int> hs = new HashSet<int>();
        
        foreach(int n in arr){
            if(n % 2 == 0 && (hs.Contains(n * 2) || hs.Contains(n / 2)))
                return true;
            else if(n % 2 != 0 && hs.Contains(n * 2))
                return true;
            hs.Add(n);
            
        }
        
        return false;        
    }
}