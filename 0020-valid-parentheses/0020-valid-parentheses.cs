public class Solution {
    public bool IsValid(string str) {
        Dictionary<char, char> dic = new Dictionary<char, char>();
        dic.Add(')', '(');
        dic.Add(']', '[');
        dic.Add('}', '{');
        
        Stack<char> stack = new Stack<char>();
        
        foreach(char c in str){
            if(dic.ContainsKey(c)){
                if(stack.Count > 0 && stack.Peek() == dic[c])
                {
                    stack.Pop();
                } else {
                    return false;
                }
            } else {
                stack.Push(c);
            }
        }
        
        return stack.Count == 0 ? true: false;
    }     
}
