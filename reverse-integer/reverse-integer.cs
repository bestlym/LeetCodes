public class Solution {
    public int Reverse(int x) {
        
        var isNegative = x < 0;
        
        var str = x.ToString().TrimStart('-');
        var negstr = str.Select(x=>x).Reverse();
        var retstr = new String(negstr.ToArray());
        
        var ret = 0;
        
        if(int.TryParse(retstr, out ret))
            if(isNegative) ret *= -1;
        
        return ret;
        
    }
}