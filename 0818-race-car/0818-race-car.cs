public class Solution {
    public int Racecar(int target) {
    
            Queue<(int moves, int pos, int speed)> queue = new Queue<(int moves, int pos, int speed)>();
            ISet<(int pos, int speed)> visited = new HashSet<(int pos, int speed)>();

            queue.Enqueue((0,0,1));

            int moves=0, pos =0, speed=0;

            while (queue.Count > 0)
            {
                (moves, pos, speed) = queue.Dequeue();

                if(pos == target)
                    return moves;

                if(visited.Contains((pos, speed)))
                {
                    continue;
                } else {
                    visited.Add((pos, speed));
                    queue.Enqueue((moves+1, pos+speed, speed*2));
                    if((pos + speed > target && speed > 0) || (pos+speed < target && speed < 0))
                    {
                        speed = (speed > 0) ? -1 : 1;
                        queue.Enqueue((moves+1, pos, speed));
                    }
                }

                
            }
            return -1;            
    }    
}