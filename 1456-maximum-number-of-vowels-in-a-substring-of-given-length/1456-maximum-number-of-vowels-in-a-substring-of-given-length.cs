public class Solution {
    public int MaxVowels(string s, int k) {
        int maxCnt = 0;
        int vowCnt = 0;
        
        for(int i = 0; i < k; i++)
        {
            if(IsVowel(s[i])) vowCnt++;
        }
        maxCnt = vowCnt;
        for(int i = k; i < s.Length; i++){
            if(IsVowel(s[i-k])) vowCnt--;
            if(IsVowel(s[i])) vowCnt++;
            maxCnt = Math.Max(maxCnt, vowCnt);
        }
        
        return maxCnt;
    }
    
    public bool IsVowel(char c){
        var arr = new List<char>{'a', 'e', 'i', 'o', 'u'};
        return arr.Contains(c);
    }
}