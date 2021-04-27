/**
 * @param {number} x
 * @return {number}
 */
var reverse = function(x) {
    const res = parseInt(x.toString().split('').reverse().join(''));
    
    if(res > Math.pow(2, 31)){
        return 0;
    } else{        
        return res * Math.sign(x);
    }    
};