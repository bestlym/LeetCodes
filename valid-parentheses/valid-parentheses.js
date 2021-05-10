/**
 * @param {string} s
 * @return {boolean}
 */
var isValid = function(s) {
    const map = {
        ')' : '(',
        ']' : '[',
        '}' : '{'        
    }
    const res = [];    
    /*
    s.split('').some(i=>{
        if(!map[i]){
            res.push(i);
        } else if(res.pop() !== map[i]) {
            return false;
        }        
    });
    
    return res.length === 0;
    */
    for (let char of s) {
        if (!map[char]) res.push(char);
        else if (res.pop() !== map[char]) return false;
    }
    return res.length === 0;
};