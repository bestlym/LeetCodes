function findWinners(matches: number[][]): number[][] {
    const map = new Map<number, number>();
    const ret1: number[] = [];
    const ret2: number[] = [];    
    
    for(let m of matches){
        
        map.set(m[0], (map.get(m[0]) || 0));
        map.set(m[1], (map.get(m[1]) || 0) + 1);
    }
    
    for(const [key, value] of map){
        if(value === 0) ret1.push(key);
        else if(value === 1) ret2.push(key);
    }
    
    ret1.sort((a,b)=>a-b);
    ret2.sort((a,b)=>a-b);
    
    return [ret1, ret2];
};