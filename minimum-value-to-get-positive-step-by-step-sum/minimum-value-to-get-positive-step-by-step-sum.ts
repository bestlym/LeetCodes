function minStartValue(nums: number[]): number {
    let sum: number=0;
    let minVal: number = 0;
    
    for(const n of nums){
        sum+=n;
        minVal = Math.min(minVal, sum);
    }
    
    return 1-minVal;
};