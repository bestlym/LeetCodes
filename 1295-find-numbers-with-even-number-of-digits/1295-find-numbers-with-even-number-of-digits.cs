public class Solution {
    public int FindNumbers(int[] nums) {
        int ret = 0;
        int numLength = 0;
        foreach(int n in nums){
            numLength = GetNumberLength(n);
            if(numLength % 2 == 0) ret++;
        }
        return ret;
    }                        
    
    private int GetNumberLength(int number){
        int ret = 0;
        while(number > 0){
            number /= 10;
            ret++;
        }
        return ret;
    }
}