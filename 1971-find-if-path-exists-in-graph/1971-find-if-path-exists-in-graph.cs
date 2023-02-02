public class Solution {
    public bool ValidPath(int n, int[][] edges, int start, int end) {
        List<List<int>> adjList = new List<List<int>>();
                
        for(int i = 0; i < n; i++)
        {
            adjList.Add(new List<int>());
        }
        
        foreach(var edge in edges)
        {
            adjList[edge[0]].Add(edge[1]);
            adjList[edge[1]].Add(edge[0]);            
        }        
       
        bool[] visited = new bool[n];
        
        if(DFS(adjList, start, end, visited))
            return true;
        
        return false;        
    }
    
    private bool DFS(List<List<int>> adjList, int start, int end, bool[] visited)
    {
        if(start == end)
            return true;
        
        visited[start] = true;
        foreach(var adj in adjList[start])
        {
            if(!visited[adj])
            {
                if(DFS(adjList, adj, end, visited))
                    return true;
            }
        }
        
        return false;
            
    }
}