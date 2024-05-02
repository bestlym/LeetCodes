function maxProfit(prices: number[]): number {
    let maxProfit: number = 0;
    let minPrice: number = Number.MAX_VALUE;
    
    for(let i=0; i < prices.length; i++){
        if(minPrice > prices[i]){
            minPrice = prices[i];
        } else if( maxProfit < prices[i] - minPrice){
            maxProfit = prices[i] - minPrice;
        }            
    }
    return maxProfit;
};