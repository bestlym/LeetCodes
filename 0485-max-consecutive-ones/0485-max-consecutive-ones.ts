function findMaxConsecutiveOnes(nums: number[]): number {
    let ret: number = 0;
    let curr: number = 0;
    
    for(const n of nums){
        if(n === 0){
            curr = 0;
            continue;
        }
        curr++;
        ret = Math.max(ret, curr);            
    }
    
    return ret;
};