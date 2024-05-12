function twoSum(nums: number[], target: number): number[] {
    //if(number.length < 2 || number = undefined) return new Array[]: number;
    const newMap = new Map();
    
    for(let i=0; i < nums.length; i++){
        const remaining = target - nums[i];
        if(newMap.has(target-nums[i])){
            return [newMap.get(remaining), i];
        }
        newMap.set(nums[i], i);
    }
    
};