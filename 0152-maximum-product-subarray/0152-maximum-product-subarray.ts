function maxProduct(nums: number[]): number {
    let ret: number = nums[0];
    let min: number=1;
    let max: number=1;
    
    for(const n of nums){
    //nums.forEach((n) => {
        const preVal = [min*n, max*n, n];
        max = Math.max(...preVal);
        min = Math.min(...preVal);
        
        ret = Math.max(max, ret);
    //});
    }
    
    return ret;
};