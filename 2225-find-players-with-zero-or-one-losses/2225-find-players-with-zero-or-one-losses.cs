public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {
        List<IList<int>> ret = new List<IList<int>>();

        SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
        
        foreach(var match in matches){
            dic[match[0]] = dic.GetValueOrDefault(match[0], 0);
            dic[match[1]] = dic.GetValueOrDefault(match[1], 0) + 1;
        }
        
        List<int> retList1 = new List<int>();
        List<int> retList2 = new List<int>();
        
        foreach(var d in dic){
            if(d.Value == 0) retList1.Add(d.Key);
            else if(d.Value == 1) retList2.Add(d.Key);
        }
        ret.Add(retList1);
        ret.Add(retList2);
            
        return ret;
    }    
}