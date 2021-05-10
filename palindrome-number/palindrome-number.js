/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function(x) {
    const y = x.toString().split('').reverse().join('');
    return y===x.toString();
};