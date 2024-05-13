function maximumSum(nums: number[]): number {
    const map: Map<number, number> = new Map();
    let ret = -1;
    
    //const digitSum = (num) => [...num.toString()].reduce((acc, val) => acc + parseInt(val), 0);
    
    const getDigitSum = (num: number): number => {
        let sum = 0;

        while (num > 0) {
            sum += num % 10;
            num = Math.floor(num / 10);
        }

        return sum;
    }
    
    for(let n of nums){
        const digit = getDigitSum(n);
        if(map.has(digit)){
            ret = Math.max(ret, map.get(digit)+n);
            if(map.get(digit) >= n) continue;
        }
        map.set(digit, n);
    }
    
    return ret;
};