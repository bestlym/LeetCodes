function twoSum(nums: number[], target: number): number[] {
    const nemMap = new Map();
    
    for(let i=0; i<nums.length;i++){
        const remaining = target - nums[i];
        if(nemMap.has(remaining)){
            console.log(remaining);
            return [nemMap.get(remaining), i];
        } 
        
        nemMap.set(nums[i], i);
    }
};