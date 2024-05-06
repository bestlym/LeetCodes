function longestOnes(nums: number[], k: number): number {
    let l: number = 0;
    let r: number = 0;
    let ret: number = 0;
    let zeroCount = 0;
    
    while(r < nums.length){
        if(nums[r] === 0){
            zeroCount++;
            while(zeroCount > k){
                if(nums[l] === 0)
                    zeroCount--;                
                l++;
            }            
        }
        r++;
        ret = Math.max(r-l, ret);
    }
    
    return ret;
};