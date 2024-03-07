public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int sLen = 200;
        StringBuilder sb = new StringBuilder();
        
        foreach(var str in strs)
        {
            sLen = Math.Min(sLen, str.Length);
        }
        
        if(sLen == 0) return "";
        
        for(int i=0; i < sLen; i++)
        {
            char cs = strs[0][i];
            for(int j = 1; j < strs.Length; j++) {
                if(cs != strs[j][i]){
                    return sb.ToString();
                }
            }
            sb.Append(cs);
        }
        return sb.ToString();
    }
}

