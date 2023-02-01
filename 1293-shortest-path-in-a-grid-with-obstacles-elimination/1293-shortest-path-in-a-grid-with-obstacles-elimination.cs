public class Solution {
    public int ShortestPath(int[][] grid, int k) {
        
        if(grid == null || grid.Length == 0)
            return -1;
        
        int m = grid.Length, n = grid[0].Length;
        Queue<(int,int,int)> queue = new Queue<(int,int,int)>();
        bool[,,] visited = new bool[m,n,k+1];
        queue.Enqueue((0,0,k));
        visited[0,0,k] = true;
        
        int[,] dirs = new int[,]{{-1,0},{1,0},{0,-1},{0,1}};
        int depth = 0;
        while(queue.Count > 0)
        {
            int size = queue.Count;
            Console.WriteLine(size);
            foreach(var q in queue)
            {
                Console.WriteLine(q);
            }
            
            for(int i = 0; i < size; i++)
            {
                var curr = queue.Dequeue();
                
                if(curr.Item1 == m - 1 && curr.Item2 == n - 1)
                    return depth;
                
                for(int j = 0; j < 4; j++)
                {
                    int nextRow = curr.Item1 + dirs[j,0];
                    int nextCol = curr.Item2 + dirs[j,1];
                    if(nextRow >= 0 && nextRow < m && nextCol >= 0 && nextCol < n)
                    {
                        if(grid[nextRow][nextCol] == 0 && !visited[nextRow,nextCol,curr.Item3])
                        {
                            queue.Enqueue((nextRow,nextCol,curr.Item3));
                            visited[nextRow,nextCol,curr.Item3] = true;
                        }
                        
                        else if(grid[nextRow][nextCol] == 1 && curr.Item3 > 0 && !visited[nextRow,nextCol,curr.Item3 - 1])
                        {
                            queue.Enqueue((nextRow,nextCol,curr.Item3 - 1));
                            visited[nextRow,nextCol,curr.Item3 - 1] = true;
                        }
                    }
                }
            }
            
            Console.WriteLine("");

            depth++;
        }
        
        return -1;
    }
}