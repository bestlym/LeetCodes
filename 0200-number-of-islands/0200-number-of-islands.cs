public class Solution {
    public int NumIslands(char[][] grid) {
        var dx = new int[]{1,-1,0,0};
        var dy = new int[]{0,0,1,-1};
        
        var queue = new Queue<(int, int)>();
        int ret = 0;
        
        for(int row=0; row < grid.Length; row++)
        {
            for(int col=0; col < grid[0].Length; col++)
            {
                if(grid[row][col] == '1')
                {
                    ret++;
                    queue.Enqueue((row, col));
                    grid[row][col] = '0';
                    
                    while(queue.Count > 0){
                        (int, int) curr = queue.Dequeue();
                        
                        for(int i=0; i < 4; i++)
                        {
                            var newX = curr.Item1 + dx[i];
                            var newY = curr.Item2 + dy[i];
                            
                            if(newX > -1 && newY > -1 && newX < grid.Length && newY < grid[0].Length && grid[newX][newY] != '0')
                            {
                                queue.Enqueue((newX, newY));
                                grid[newX][newY] = '0';
                            }
                                
                        }
                    }
                }
            }
        }
        return ret;
        
    }
}
