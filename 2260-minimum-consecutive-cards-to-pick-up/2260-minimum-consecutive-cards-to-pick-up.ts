function minimumCardPickup(cards: number[]): number {
    const map: Map<number, number> = new Map();
    let ret: number = Number.MAX_VALUE;
    
    for(let i=0; i < cards.length; i++){
        if(map.has(cards[i])) ret = Math.min(ret, i-map.get(cards[i])+1);
        map.set(cards[i], i);
    }
    
    return (ret === Number.MAX_VALUE) ? -1 : ret;
};