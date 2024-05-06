function getAverages(nums: number[], k: number): number[] {
    if(k < 1) return nums;
    let ret: number[] = new Array<number>(nums.length);
    ret.fill(-1);
    
    let start: number = k;
    let end: number = nums.length-k-1;
    
    const num: number = nums.length;
    let preSum: number = 0;
    let r: number = k*2+1;
    
    for(let i=0; i < Math.min(num, r); i++){
        preSum += nums[i];
    }
    
    while(start <= end){
        ret[start] = Math.floor(preSum / r);
        if(start+1 <= end){
            preSum = preSum + nums[start+k+1] - nums[start-k];
        }
        start++;
    }
    
    return ret;
};