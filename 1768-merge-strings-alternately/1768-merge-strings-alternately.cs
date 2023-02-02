public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder sb = new StringBuilder();
        int word1Index = 0, word2Index = 0;
        while (word1Index + word2Index < word1.Length + word2.Length)
        {
            if (word1Index < word1.Length){
                sb.Append(word1[word1Index]);
                word1Index++;
            }
            if (word2Index < word2.Length){
                sb.Append(word2[word2Index]);
                word2Index++;
            } 
        }
        return sb.ToString();
        
    }
}