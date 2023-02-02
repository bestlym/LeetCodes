public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for(int i=0; i < arr.Length; i++){
            if(dic.ContainsKey(arr[i])){
                dic[arr[i]]++;
            } else {
                dic.Add(arr[i], 1);
            }            
        }
        
        var counts = new HashSet<int>();
        foreach(var d in dic){
            if(counts.Contains(d.Value)) return false;
            counts.Add(d.Value);
        }
        return true;
    
    }
}