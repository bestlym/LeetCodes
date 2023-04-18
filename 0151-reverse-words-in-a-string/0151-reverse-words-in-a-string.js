/**
 * @param {string} str
 * @returns {string}
 */
var reverseWords = function(str) {
    var result = [];
    if(str===null||str.length===0) return ''; // when the string is empty
    var words = str.match(/\S+/g);
    if(words===null) return ''; //if the str only contain whitespaces
    var len = words.length;
    
    for(var i = 0; i < len; i++){
        var last = words.pop();
        words.splice(i, 0, last);
    }
    
    return words.join(' ');
};