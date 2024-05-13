public class Solution {
    public int MinimumCardPickup(int[] cards) {
        int min = int.MaxValue;
        int ret = 0, left=0;
        HashSet<int> hs = new HashSet<int>();
        
        for(int i=0; i < cards.Length; i++){
            if(hs.Contains(cards[i])){
                while(hs.Contains(cards[i]) && hs.Count > 0 ){
                    hs.Remove(cards[left]);
                    left++;
                }
                min = Math.Min(min, hs.Count+2);
            }
            
            hs.Add(cards[i]);
        }
        
        return min == int.MaxValue ? -1 : min;
        
    }
}



