public class Solution {
    public string ReverseWords(string s) {
        var res = s.Trim().Split(" ").Where(x => !x.Trim().Equals(string.Empty)).Reverse();
        return string.Join(" ", res);
        
    }
}