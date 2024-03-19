public class Solution {
    public int NumIslands(char[][] grid) {
        int[] dx = new int[]{1, -1, 0, 0};
        int[] dy = new int[]{0, 0, 1, -1};
        
        Queue<int[]> q = new Queue<int[]>();
        int res = 0;
        
        for(int i=0; i < grid.Length; i++)
        {
            for(int j=0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == '1')
                {
                    res++;
                    q.Enqueue(new int[]{i, j});
                    grid[i][j] = '0';
                    
                    while(q.Count > 0)
                    {
                        int[] curr = q.Dequeue();
                        
                        for(int k=0; k < 4; k++)
                        {
                            var newX = curr[0] + dx[k];
                            var newY = curr[1] + dy[k];
                            
                            if(newX > -1 && newY > -1 && newX < grid.Length && newY < grid[0].Length
                              && grid[newX][newY] != '0')
                            {
                                q.Enqueue(new int[]{newX, newY});
                                grid[newX][newY] = '0';
                            }
                                
                        }
                    }                    
                }
            }
        }
        return res;
        
    }
}
