function maxProfit(prices: number[]): number {
    let maxProfit: number = 0;
    let minPrice: number = Number.MAX_VALUE;
    
    for(let i=0; i < prices.length; i++){
        if(minPrice > prices[i]){
            minPrice = prices[i];
        } else if(prices[i] - minPrice > maxProfit){
            maxProfit = prices[i] - minPrice;
        }            
    }
    return maxProfit;
};