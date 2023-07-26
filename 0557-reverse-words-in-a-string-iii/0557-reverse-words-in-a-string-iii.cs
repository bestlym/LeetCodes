public class Solution {
    public string ReverseWords(string s) {        
        char[] charArr = s.ToCharArray();        
        int left = 0, right = 0;
        
        for(; right < s.Length; right++){
            
            if(charArr[right] == ' '){
                ReverseWord(charArr, left, right-1);
                left = right+1;
            }
        }
        ReverseWord(charArr, left, right-1);
        return new String(charArr);
    }
    
    private void ReverseWord(char[] s, int left, int right){
        //Console.WriteLine(new String(s));
        while(left < right){
            (s[left], s[right]) = (s[right], s[left]);            
            left++;
            right--;
        }
    }
}