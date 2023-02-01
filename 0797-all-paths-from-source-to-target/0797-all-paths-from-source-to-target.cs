public class Solution {    
    private int target;
    private IList<IList<int>> result;
    private int[][] graph;
    
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        this.target = graph.Length - 1;
        this.graph = graph;
        this.result = new List<IList<int>>();
        
        var path = new LinkedList<int>();
        path.AddLast(0);

        Backtracking(0, path);

        return result;
    }
    
    private void Backtracking(int currNode, LinkedList<int> path)
    {
        if(currNode == target)
        {
            result.Add(new List<int>(path));
            return;
        }
        
        foreach(var curr in graph[currNode]){
            path.AddLast(curr);
            Backtracking(curr, path);
            path.RemoveLast();
        }
    }    
}