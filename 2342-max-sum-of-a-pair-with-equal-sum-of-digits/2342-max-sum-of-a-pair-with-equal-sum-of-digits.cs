public class Solution {
    public int MaximumSum(int[] nums) {
        var dic = new Dictionary<int, int>();
        int ret = int.MinValue;
        
        foreach(int n in nums){
            var digit = GetSumOfDigits(n);
            if(dic.ContainsKey(digit)) 
            {
                ret = Math.Max(ret, dic[digit]+n);
                if(dic[digit] >= n) continue;
            }
            dic[digit] = n;
        }
        return (ret == int.MinValue) ? -1 : ret;
        
    }
    public int GetSumOfDigits(int num){
        int ret = 0;
        while(num > 0)
        {
            ret+=num%10;
            num /= 10;
        }
        return ret;
    }
}