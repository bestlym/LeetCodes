function maxSubArray(nums: number[]): number {
    if(nums.length == 0) return 0
    if(nums.length == 1) return nums[0];
    
    let sum: number = 0;
    let ret: number = nums[0];
    
    for(const n of nums){
        sum+=n;
        if(ret < sum) ret = sum;
        if(sum < 0) sum = 0;
    }
    
    return ret;
};