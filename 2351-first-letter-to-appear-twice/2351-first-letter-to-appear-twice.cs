public class Solution {
    public char RepeatedCharacter(string s) {

        List<char> dic = new List<char>();
        
        for(int i=0; i < s.Length; i++){
            if(dic.Contains(s[i])){
                return s[i];
            }
            dic.Add(s[i]);
        }
        return new char();
    }
}