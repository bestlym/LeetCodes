public class Logger {
    
    Dictionary<string, int> dic;
    
    public Logger() {
        dic = new();
    }
    
    public bool ShouldPrintMessage(int timestamp, string message) {
        if(!dic.ContainsKey(message)){
            dic.Add(message, timestamp);
            return true;
        }
        else{
            if(timestamp - dic[message] >= 10){
                dic[message] = timestamp;
                return true;
            }
        }
        return false;
        
    }
}

/**
 * Your Logger object will be instantiated and called as such:
 * Logger obj = new Logger();
 * bool param_1 = obj.ShouldPrintMessage(timestamp,message);
 */