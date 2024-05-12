function repeatedCharacter(s: string): string {
    const hs = new Set();
    
    for(let c of s){
        if(hs.has(c)) return c;
        hs.add(c);
    }
};