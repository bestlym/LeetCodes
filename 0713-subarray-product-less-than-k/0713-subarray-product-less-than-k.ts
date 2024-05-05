function numSubarrayProductLessThanK(nums: number[], k: number): number {
    if(k <= 1) return 0;
    
    let cnt: number = 0;
    let currProd: number = 1;
    let left: number = 0;
    
    for(let right=0; right < nums.length; right++){
        currProd *= nums[right];
        
        while(currProd >= k){
            currProd /= nums[left];
            left++;
        }
        cnt += right-left+1;
    }
    return cnt;
};