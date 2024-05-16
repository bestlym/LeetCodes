public class Solution {
    public string MakeGood(string s) {
        Stack<char> stack = new Stack<char>();
        
        foreach(char c in s){
            if(stack.Count()>0){
                var prev = stack.Peek();
                if(prev != c && Char.ToLower(prev) == Char.ToLower(c)){
                    stack.Pop();
                } else {
                    stack.Push(c);
                }
                
            } else {
                stack.Push(c);
            }
        }
        
        var res = stack.ToArray();
        Array.Reverse(res);
        
        return new String(res);
    }
}