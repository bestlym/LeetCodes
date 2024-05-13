function findMaxLength(nums: number[]): number {
    const map = new Map<number, number>();
    let sum: number = 0;
    let ret: number = 0;
    map.set(0, -1);
    
    
    for(let i=0; i < nums.length; i++){
        sum += (nums[i] === 1 ? 1 : -1);
        if(map.has(sum)){
            ret = Math.max(ret, i-map.get(sum));
        } else {
            map.set(sum, i);
        }            
    }    
    return ret;    
};