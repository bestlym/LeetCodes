public class Solution {
    public int Reverse(int x) {
        
        var isNegative = x < 0;
        
        var str = x.ToString().TrimStart('-');
        var seg = str.Select(x=>x).Reverse();
        var revstr = new string(seg.ToArray());
        
        var ret = 0;
        
        if(int.TryParse(revstr, out ret))
            if(isNegative) ret *= -1;
        
        return ret;
        
    }
}