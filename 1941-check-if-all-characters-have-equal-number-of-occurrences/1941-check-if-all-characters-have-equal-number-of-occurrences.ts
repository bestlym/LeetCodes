function areOccurrencesEqual(s: string): boolean {
    const map = new Map<string, number>();
    
    for(let c of s){
        map.set(c, (map.get(c) || 0) + 1);
    }
    const arr = new Set(map.values());
    return arr.size === 1;
};