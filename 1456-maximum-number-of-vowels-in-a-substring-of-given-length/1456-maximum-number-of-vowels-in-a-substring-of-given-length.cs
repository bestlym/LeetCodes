public class Solution {
    public int MaxVowels(string s, int k) {
        
        char[] arr = {'a', 'e', 'i', 'o', 'u'};
        
        int maxCnt = 0;
        int vowCnt = 0;
        
        for(int i = 0; i < k; i++)
        {
            if(Array.IndexOf(arr, s[i]) >=0 ) vowCnt++;
        }
        maxCnt = vowCnt;
        for(int i = k; i < s.Length; i++){
            if(Array.IndexOf(arr, s[i-k]) >= 0) vowCnt--;
            if(Array.IndexOf(arr, s[i]) >= 0) vowCnt++;
            maxCnt = Math.Max(maxCnt, vowCnt);
        }
        
        return maxCnt;
    }
}