public class Solution {
    public string SimplifyPath(string path) {
        if (path == null || path == string.Empty)
            return path;
        
        var pathStr = path.Split('/');
        Stack<string> stack = new Stack<string>();
        
        foreach(var str in pathStr){
            if(str != string.Empty){
                if(str == "."){
                    continue;
                } else if(str == ".."){
                    if (stack.Count > 0) {
                        stack.Pop();
                    }
                } else {
                    stack.Push(str);
                }    
            }
            
        }
        
        var sb = new StringBuilder();
        
        while(stack.Count > 0){
            sb.Insert(0, "/" + stack.Pop());
        }
        
        return sb.Length == 0 ? "/" : sb.ToString();
        
    }
}