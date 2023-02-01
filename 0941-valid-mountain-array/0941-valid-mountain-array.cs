public class Solution {
    public bool ValidMountainArray(int[] arr) {
        if(arr == null || arr.Length < 3)
            return false;
        
        int i = 0;

        while(i < arr.Length - 1 && arr[i] < arr[i+1])
            i++;
        
        if(i == 0 || i == arr.Length - 1)
            return false;
        
        while(i < arr.Length - 1 && arr[i] > arr[i+1])
            i++;
        
        return i == arr.Length -1;
    }
}