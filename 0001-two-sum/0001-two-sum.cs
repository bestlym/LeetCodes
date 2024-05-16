public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int, int> dic = new Dictionary<int, int>();
        
        for(int i=0; i<nums.Length; i++)
        {
            if(dic.TryGetValue(target - nums[i], out int r)){
                return new int[2]{i, r};
            }
            //dic.Add(nums[i], i);
            dic[nums[i]] = i;     
        }
        
        return new int[2];
    }
}
