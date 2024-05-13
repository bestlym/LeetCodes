public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {
        IList<IList<int>> ret = new List<IList<int>>();

        Dictionary<int, int> dic = new Dictionary<int, int>();
        
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
        ret.Add(retList1.OrderBy(x => x).ToList());
        ret.Add(retList2.OrderBy(x => x).ToList());
        
        //ret[0] = ret[0].OrderBy(x => x).ToList();
        //ret[1] = ret[1].OrderBy(x => x).ToList();
            
        return ret;
    }    
}