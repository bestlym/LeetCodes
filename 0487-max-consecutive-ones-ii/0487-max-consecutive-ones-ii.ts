function findMaxConsecutiveOnes(nums: number[]): number {
    let l: number = 0;
    let r: number = 0;
    let ret: number=0;
    let zeroCnt: number = 0;
    
    while(r < nums.length){
        if(nums[r] === 0){
            zeroCnt++;
            while(zeroCnt > 1){
                if(nums[l] === 0){
                    zeroCnt--;
                }
                l++;
            }            
        }        
        
        r++;
        ret = Math.max(ret, r-l);
    }
    
    return ret;
};