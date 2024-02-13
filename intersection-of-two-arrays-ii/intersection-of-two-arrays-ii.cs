public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> ret = new List<int>();
        
        int first = 0, second = 0;
        
        Array.Sort(nums1);
        Array.Sort(nums2);
        
        while(nums1.Length > first && nums2.Length > second)
        {
            if(nums1[first] == nums2[second])
            {
                ret.Add(nums1[first]);
                first++;
                second++;
            }
            else if(nums1[first] > nums2[second])
            {
                second++;
            } else {
                first++;
            }
            
        }
        
        return ret.ToArray();
        
    }
}