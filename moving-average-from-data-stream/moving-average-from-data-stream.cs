public class MovingAverage {
    private Queue<int> queue;
    private int Size;    
    private double sum;
    
    public MovingAverage(int size) {
        queue = new Queue<int>();
        Size = size;
    }
    
    public double Next(int val) {
        sum+= val;
        queue.Enqueue(val);
        
        if(queue.Count > Size)
            sum -= queue.Dequeue();
        
        return sum / queue.Count;
        
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */