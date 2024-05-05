function findMaxAverage(nums: number[], k: number): number {
    let sum: number=0;
    
    for(let i=0; i < k; i++){
        sum += nums[i];        
    }

    let ret: number = sum;
    for(let i=k; i < nums.length;i++){
        sum += (nums[i]-nums[i-k]);
        ret = Math.max(sum, ret);        
    }
    
    return ret / k;
    
};