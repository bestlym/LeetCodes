public class Solution {
    public int MinimumCardPickup(int[] cards) {
        var dic = new Dictionary<int, int>();
        int ret = int.MaxValue;
        //int minValue = int.MaxValue;
        
        for(int i=0; i < cards.Length; i++)
        {
            if(dic.ContainsKey(cards[i])) ret = Math.Min(ret, i-dic[cards[i]]+1);
            dic[cards[i]] = i;
        }
        
        return (ret == int.MaxValue) ? -1 : ret;
        
    }
}



