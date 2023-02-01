public class Solution {
    public int WordsTyping(string[] sentence, int rows, int cols) {
        string joinedStr = string.Join(" ", sentence) + " ";
        int ret = 0;

        for(int i = 0; i < rows; i++)
        {
            //row = 0
            ret += cols; //8
            
            if(joinedStr[ret % joinedStr.Length] == ' '){
                ret++;
            }else{
                while(ret > 0 && joinedStr[(ret-1) % joinedStr.Length] != ' '){
                    ret--;
                }                    
            }
        }

        return ret / joinedStr.Length;
    }
}