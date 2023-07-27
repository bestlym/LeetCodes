public class Solution {
    public int MaxVowels(string s, int k) {
        
        var arr = new List<char>{'a', 'e', 'i', 'o', 'u'};
        
        int maxCnt = 0;
        int vowCnt = 0;
        
        for(int i = 0; i < k; i++)
        {
            if(arr.Contains(s[i])) vowCnt++;
        }
        maxCnt = vowCnt;
        for(int i = k; i < s.Length; i++){
            if(arr.Contains(s[i-k])) vowCnt--;
            if(arr.Contains(s[i])) vowCnt++;
            maxCnt = Math.Max(maxCnt, vowCnt);
        }
        
        return maxCnt;
    }
}