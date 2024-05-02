function containsDuplicate(nums: number[]): boolean {
    const numsMap = new Map();
    for(let i=0; i < nums.length; i++){
        if(numsMap.has(nums[i])) return true;
        numsMap.set(nums[i], i);
    }
    return false;
};