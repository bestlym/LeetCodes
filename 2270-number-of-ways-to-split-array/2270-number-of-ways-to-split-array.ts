function waysToSplitArray(nums: number[]): number {
    let sum:number=0;
    const prefix = nums.map(val => sum+=val);
    
    let ret: number=0;
    
    for(let i=0; i < prefix.length-1; i++){
        if(prefix[i] >= (prefix[prefix.length-1]-prefix[i]))
            ret++;
    }

    return ret;
    
};