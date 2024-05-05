function sortedSquares(nums: number[]): number[] {
    const ret: number[] = [];
    let left: number = 0;
    let right: number = nums.length-1;
    
    for(let i = nums.length-1; i >= 0; i--){
        if(Math.abs(nums[right]) > Math.abs(nums[left])){
            ret[i] = nums[right] * nums[right];
            right--;
        } else {
            ret[i] = nums[left] * nums[left];
            left++;
        }
    }
    return ret;
};