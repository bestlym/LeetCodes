public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums == null || nums.Length < 2) return new int[2];
        
        var dic = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(dic.TryGetValue(target - nums[i], out int r))
            {
                return new int[2]{r, i};
            }
            dic[nums[i]] = i;
        }
        return new int[2];

    }
}
