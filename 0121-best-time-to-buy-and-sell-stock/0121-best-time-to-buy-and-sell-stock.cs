public class Solution {
    public int MaxProfit(int[] prices) {
        int buyPrice = prices[0];
        int profit = 0;
            
        foreach(int p in prices){
            buyPrice = Math.Min(buyPrice, p);
            profit = Math.Max(profit, p-buyPrice);
        }
        
        return profit;
    }
}


