public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var ret = new List<IList<string>>();
        var dic = new Dictionary<string, List<string>>();
        
        foreach(var s in strs)
        {
            var chars = s.ToCharArray();
            Array.Sort(chars);
            string keyStr = new String(chars);
            if(dic.ContainsKey(keyStr))
                dic[keyStr].Add(s);
            else {
                dic[keyStr] = new List<string>() {s};
            }
        }
        
        foreach(var d in dic){
            ret.Add(d.Value);
        }
        
        return ret;
    }
}