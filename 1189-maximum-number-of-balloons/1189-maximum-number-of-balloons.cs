public class Solution {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        int ret = text.Length;
        char[] charArr = {'b', 'a', 'l', 'o', 'n'};
        
        foreach(char c in text){            
            if(charArr.Contains(c)) {
                dic[c] = dic.GetValueOrDefault(c, 0) + 1;
            }                
        }        
        
        foreach(var d in charArr) {
            int charCnt = dic.GetValueOrDefault(d, 0);
            if(d == 'l' || d == 'o') charCnt = charCnt/2;
            ret = Math.Min(ret, charCnt);
        }
        return ret;
    }
}