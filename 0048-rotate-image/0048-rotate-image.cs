public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;  //4
        int l = n-1;
        
        for(int i=0; i < (n+1) / 2; i++){   /// 2
            for(int j=0; j < n/2; j++){   /// 2
                int temp = matrix[l-j][i];   //2 1
                
                //2 1           1    
                matrix[l-j][i] = matrix[l-i][l-j];   
                matrix[l-i][l-j] = matrix[j][l-i];
                matrix[j][l-i] = matrix[i][j];
                matrix[i][j] = temp;
            }
        }        
    }
}

