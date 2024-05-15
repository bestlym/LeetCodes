public class Solution {
    public bool BackspaceCompare(string s, string t) {
        var test1 = BuildStack(s);
        var test2 = BuildStack(t);

        return (test1 == test2);
    }
    
    public string? BuildStack(string s){
        var stack = new Stack<char>();
        
        foreach(char c in s){
            if(c != '#')
            {
                stack.Push(c);                
            } else {
                stack.TryPop(out char r);
            }
        }
        
        return string.Concat(stack);
    }
}