public class Solution {
    public bool AreOccurrencesEqual(string s) {
        
        bool ret = true;

        Dictionary<char, int> dic = new Dictionary<char, int>();
        
        for(int i = 0; i < s.Length; i++){
            if(dic.ContainsKey(s[i])) dic[s[i]]++;
            else dic.Add(s[i], 1);
        }        
        
        return dic.Values.Distinct().Count() == 1;
        
    }
}