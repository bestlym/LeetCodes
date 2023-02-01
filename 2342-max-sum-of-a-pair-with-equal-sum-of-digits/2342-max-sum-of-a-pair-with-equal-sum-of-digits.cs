public class Solution {
    public int MaximumSum(int[] nums) {
        Dictionary<int, int> hs = new Dictionary<int, int>();
        int left = 0, max = -1;
        
        foreach(int n in nums){
            //int[] numArr = n.ToIntArray();
            List<int> numArr = new List<int>();
            int n2 = n;
            while (n2 > 0){
                numArr.Add(n2 % 10);
                n2 /= 10;
            }
            
            var currSum = numArr.Sum();

            if(hs.ContainsKey(currSum)){
                
                max = Math.Max(max, n + hs[currSum]);
                
                if (hs[currSum] < n)
                    hs[currSum] = n;
            } else {
                hs[currSum] = n;
            }
            
        }
        return max;
    }
}