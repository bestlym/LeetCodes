function subarraySum(nums: number[], k: number): number {
    const map = new Map();
    map.set(0, 1);
    let ret = 0;
    let curr = 0;
    
    for(let i of nums){
        curr += i;
        ret += map.get(curr-k) || 0;
        map.set(curr, (map.get(curr) || 0) + 1);        
    }
    return ret;
};