public class Solution {
    public string ReversePrefix(string word, char ch) {
        char[] c = word.ToCharArray();
        int left = 0;
        
        int right = Array.IndexOf(c, ch);
        
        if(right < 0) return word;

        while(left < right){
            (c[left], c[right]) = (c[right], c[left]);
            left++;
            right--;
        }
        
        return new String(c);

    }
}