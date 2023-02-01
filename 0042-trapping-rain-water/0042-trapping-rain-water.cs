public class Solution {
    public int Trap(int[] height) {
        if(height == null || height.Length == 0)
            return 0;
        
        int left = 0, right = height.Length-1, ret = 0;
        int leftMax = height[left], rightMax = height[right];
        
        while(left < right){
            if(leftMax < rightMax){
                ret += Math.Max(0, leftMax - height[left]);
                left++;
                leftMax = Math.Max(leftMax, height[left]);
            } else {
                ret += Math.Max(0, rightMax - height[right]);
                right--;
                rightMax = Math.Max(rightMax, height[right]);
            }
        }
        
        return ret;
    }
}