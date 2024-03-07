public class Solution {
    public int MyAtoi(string str) {
        int index = 0, sign = 1, total = 0;
        
        str = str.Trim();
        
        if(str.Length == 0) return 0;
        
        if(str[index] == '+' || str[index] == '-'){
            sign = str[index] == '+' ? 1 : -1;
            index++;
        }
        
        while(index < str.Length){
            
            if(!char.IsNumber(str[index])) break;
            
            int digit = Int32.Parse(str[index].ToString());
            
            if(Int32.MaxValue/10 < total || Int32.MaxValue/10 == total && Int32.MaxValue%10 < digit)
                return sign == 1 ? Int32.MaxValue : Int32.MinValue;
            
            total = 10 * total + digit;
            index++;
        }
        return total * sign;
    }
}