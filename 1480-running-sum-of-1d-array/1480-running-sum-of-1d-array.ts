function runningSum(nums: number[]): number[] {
    let sum=0;
    return nums.map((val) => sum+=val);
};