public class Solution {
    public string DecodeString(string s) {
        
        if(string.IsNullOrEmpty(s))
        {
            return "";
        }
        
        Stack<char> stack = new Stack<char>();
        var ret = "";
        
        foreach(char c in s)
        {
            if(c == ']')
            {
                var str = "";
                StringBuilder sb = new StringBuilder();
                
                while(stack.Count > 0 && stack.Peek() != '[')
                {
                    str = stack.Pop() + str;
                }
                
                //remove '['
                stack.Pop();
                
                int cnt = 0;
                int digit = 0;
                
                while(stack.Count > 0 && stack.Peek() >= '0' && stack.Peek() <= '9')
                    cnt += (int)Math.Pow(10, digit++) * (stack.Pop() - '0');
                
                while(cnt > 0)
                {
                    sb.Append(str);
                    cnt--;
                }
                
                foreach(var ch in sb.ToString())
                    stack.Push(ch);                
                
            } else 
            {
                stack.Push(c);
            }
        }
        
        return String.Join("", stack.Reverse());
    }
}