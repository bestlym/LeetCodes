function intersection(nums: number[][]): number[] {
    const map = new Map<number, number>();
    const ret = [];
    
    for(let arr of nums){
        for(let n of arr){
            map.set(n, (map.get(n) || 0) + 1);
        }
    }
    
    for(const [key, value] of map){
        if(value === nums.length) ret.push(key);
    }
    
    return ret.sort((a,b) => a-b);
    
};