function equalPairs(grid: number[][]): number {
    const map: Map<string, number> = new Map();
    let ret: number = 0;
    
    grid.forEach((item)=>{
        const arrStr:string = item.join(' ');
        map[arrStr] = (map[arrStr] || 0) +1;
    });

    for(let i=0; i< grid.length; i++){
        const arr = [];
        for(let j=0; j < grid.length; j++){
            arr.push(grid[j][i]);
        }

        ret+= (map[arr.join(' ')] || 0);
    }
    
    return ret;
};