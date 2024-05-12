public class Solution {
    public bool AreOccurrencesEqual(string s) {
        var dic = new Dictionary<int, int>();
        
        foreach(char c in s){
            if(dic.ContainsKey(c)) dic[c]++;
            else dic[c] = 1;
        }
        
        var piv = dic[s[0]];
        
        return dic.Where(w=>w.Value != piv).Count() == 0;
    }
}