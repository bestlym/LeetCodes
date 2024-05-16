public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int curr = k;
        
        var dic = new Dictionary<int, int>();

        foreach (int n in nums)
        {
            if (!dic.TryAdd(n, 1)) dic[n]++;
        }

        dic = dic.OrderByDescending(x => x.Key).ToDictionary();

        foreach (var d in dic)
        {
            curr -= d.Value;
            Console.WriteLine(curr);
            if(curr <= 0) return d.Key;              
        }
        
        return 0;
        
    }
}