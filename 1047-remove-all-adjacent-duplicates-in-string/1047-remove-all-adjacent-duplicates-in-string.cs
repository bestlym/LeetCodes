public class Solution {
    public string RemoveDuplicates(string s) {
        Stack<char> stack = new Stack<char>();

        foreach(char c in s)
        {
            if(stack.Count > 0 && stack.Peek() == c)
            {
                stack.Pop();
            } else {
                stack.Push(c);
            }
        }
        
        return string.Concat(stack.Reverse());
    }
}