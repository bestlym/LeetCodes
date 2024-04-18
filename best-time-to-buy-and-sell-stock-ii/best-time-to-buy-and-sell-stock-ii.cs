public class Solution {
    
    public int MaxProfit(int[] prices) {
       
        if(prices.Length == 0 || prices == null) return 0;
        
        for(int i=1; i < prices.Length; i++)
        {
            if(prices[i] - prices[i-1] > 0)
            {
                prices[i-1] = prices[i] - prices[i-1];
            } else {
                prices[i-1] = 0;
            }
        }
        prices[prices.Length-1] = 0;
        return prices.Sum();
    }
}