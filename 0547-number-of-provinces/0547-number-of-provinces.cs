public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        if(isConnected == null)
            return 0;

        bool[] visited = new bool[isConnected.Length];
        int res = 0;
        Stack<int> stack = new Stack<int>();

        for(int i = 0; i < isConnected.Length; i++){
            if(visited[i])
                continue;
            
            stack.Push(i);
            visited[i] = true;
            while(stack.Count > 0)
            {
                var curr = stack.Pop();

                for(int j = 0; j < isConnected.Length; j++)
                {
                    if(!visited[j] && isConnected[curr][j] == 1){
                        stack.Push(j);
                        visited[j] = true;
                    }
                }
            }
            res++;
        }

        return res;
    }
}