function countElements(arr: number[]): number {
    const hs = new Set<number>(arr);
    
    let ret = 0;
    
    for(let i of arr){
        if(hs.has(i+1)) ret++;
    }
    
    return ret;
    
};