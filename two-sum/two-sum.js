/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    let res = [];
    nums.map(function(item, index, data){
        const num = target-item
        if(data.filter((filterItem, filterIndex)=>filterIndex != index).includes(num)){
            res.push(index);            
        }        
        
    });
    return res;
};