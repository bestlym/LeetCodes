function waysToSplitArray(nums: number[]): number {
    const prefix: number[] = nums.reduce(function(acc, val, idx){
        if(idx === 0){
            acc.push(val);
        } else {
            acc.push(acc[idx-1]+val);
        }
        return acc;
    }, []);
    
    let ret: number=0;
    
    for(let i=0; i < prefix.length-1; i++){
        if(prefix[i] >= (prefix[prefix.length-1]-prefix[i]))
            ret++;
    }

    return ret;
    
};