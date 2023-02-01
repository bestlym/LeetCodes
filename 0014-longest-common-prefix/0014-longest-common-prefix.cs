public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int sLength = 200;
        StringBuilder sb = new StringBuilder();
        
        foreach(string s in strs){
            sLength = Math.Min(s.Length, sLength);            
        }
        
        if(sLength == 0) return "";
        for(int i = 0; i < sLength; i++){
            char c = strs[0][i];
            for(int j = 0; j < strs.Length; j++) {
                if(c != strs[j][i]){
                    return sb.ToString();
                }
            }
            sb.Append(c);
        }
        
        return sb.ToString();
    }
}

