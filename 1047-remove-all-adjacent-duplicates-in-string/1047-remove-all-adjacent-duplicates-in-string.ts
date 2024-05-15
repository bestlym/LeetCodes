function removeDuplicates(s: string): string {
    const stack: string[] = [];
    //Array.constructor.prototype.peek: any = () => {stack[stack.length-1] || ""};
    
    for(const c of s)
    {
        //stack.constructor.prototype.peek = () => stack[stack.length-1] || "";
        const peek = () => stack[stack.length-1] || "";
        
        if(peek() == c){
            stack.pop();
        } else {
            stack.push(c);
        }
    }
    return stack.join("");
};