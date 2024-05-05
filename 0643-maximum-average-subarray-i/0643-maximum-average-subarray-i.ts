function findMaxAverage(nums: number[], k: number): number {
    let sum: number=0;
    let ret: number=0;
    let left: number=0;
    
    for(let i=0; i < k; i++){
        sum += nums[i];
        
    }

    ret = sum;
    for(let i=k; i < nums.length;i++){
        sum += (nums[i]-nums[left]);
        ret = Math.max(sum, ret);
        left++;        
        
    }
    
    return ret / k;
    
};