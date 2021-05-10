/**
 * @param {string[]} strs
 * @return {string}
 */
var longestCommonPrefix = function(strs) {
    let res = "";
    strs[0].split("").some((item, index, data) => {
        for(let i=1; i < strs.length; i++){
            if(item !== strs[i][index]){
                return true;
            }
        }
        res += item;
    });
    return res;
};