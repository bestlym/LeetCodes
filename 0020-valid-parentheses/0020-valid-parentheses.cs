public class Solution {
    public bool IsValid(string str) {
        var dic = new Dictionary<char, char>();
        dic.Add(')', '(');
        dic.Add('}', '{');
        dic.Add(']', '[');
        
        var stack = new Stack<char>();        
        
        foreach(char c in str)
        {            
            if(stack.Count > 0 && dic.ContainsKey(c)){
                if(stack.Pop() != dic[c]) return false;
            } else {
                stack.Push(c);
            }
        }
        
        return stack.Count == 0;
    }     
}
