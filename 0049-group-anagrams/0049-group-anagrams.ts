function groupAnagrams(strs: string[]): string[][] {
    const hm: Map<string, string[]> = new Map();
    const ret: string[][] = [];
    for(const s of strs){
        const keyStr = s.split('').sort().join('');
        
        if(!hm.has(keyStr)) hm.set(keyStr, []);
        hm.get(keyStr).push(s);
    }
    
    return [...hm.values()];
};