public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1, j = n - 1, index = m + n - 1;
        
        while(i >= 0 && j >= 0)
        {
            if(nums1[i] > nums2[j])
            {
                nums1[index] = nums1[i];
                i--;
            }
            else
            {
                nums1[index] = nums2[j];
                j--;
            }

            index--;
        }
        
		// No need to handle i >= 0 case. If it's the case, the remaining numbers are already in nums1.
        while(j >= 0)
        {
            nums1[index] = nums2[j];
            index--;
            j--;
        }
    }
}