function checkIfPangram(sentence: string): boolean {
    if(sentence.length < 26) return false;
    
    let hs = new Set<string>();
    
    for(let c of sentence){
        hs.add(c);
    }
    return hs.size === 26;
};