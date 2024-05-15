public class StockSpanner {
    
    Stack<(int, int)> stack;
    
    public StockSpanner() {
        stack=new Stack<(int, int)>();        
    }
    
    public int Next(int price) {
        int cnt = 0;
        
        while(stack.Count > 0 && stack.Peek().Item1 <= price)
        {
            cnt+=stack.Pop().Item2;
        }
        
        stack.Push((price, cnt+1));
        
        return cnt+1;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */