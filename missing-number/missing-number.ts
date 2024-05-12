function missingNumber(nums: number[]): number {
    let sum: number = nums.length * (nums.length+1) / 2;
    
    for(const n of nums){
        sum -= n;
    }
    
    return sum;
};