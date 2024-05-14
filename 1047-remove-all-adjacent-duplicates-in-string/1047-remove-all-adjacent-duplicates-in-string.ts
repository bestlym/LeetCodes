function removeDuplicates(s: string): string {
    const stack: string[] = [];
    
    for(const c of s)
    {
        const peek = () => stack[stack.length-1] || "";
        
        if(peek() == c){
            stack.pop();
        } else {
            stack.push(c);
        }
    }
    return stack.join("");
};