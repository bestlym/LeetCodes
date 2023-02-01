public class Solution {
    public bool BackspaceCompare(string s, string t) {
        return CheckStr(s) == CheckStr(t);
    }

    public string CheckStr(string str)
    {
        if(str.Length == 0)
            return "";

        Stack<char> stack = new Stack<char>();

        foreach(var s in str){
            if(s != '#'){
                stack.Push(s);
            } else if(stack.Count > 0){
                stack.Pop();
            }
        }
        //Console.WriteLine(new string(stack.ToArray()));
        return new string(stack.ToArray()); //stack.ToString();
    }
}