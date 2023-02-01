/**
 * // This is the robot's control interface.
 * // You should not implement it, or speculate about its implementation
 * interface Robot {
 *     // Returns true if the cell in front is open and robot moves into the cell.
 *     // Returns false if the cell in front is blocked and robot stays in the current cell.
 *     public bool Move();
 *
 *     // Robot will stay in the same cell after calling turnLeft/turnRight.
 *     // Each turn will be 90 degrees.
 *     public void TurnLeft();
 *     public void TurnRight();
 *
 *     // Clean the current cell.
 *     public void Clean();
 * }
 */

class Solution {
    private readonly (int, int)[] directions = {(-1, 0),(0, 1),(1,0),(0, -1) };
    private HashSet<(int, int)> visited = new HashSet<(int, int)>();
    private Robot robot;
    
    public void CleanRoom(Robot robot) {
        this.robot = robot;
        Backtrack(0,0,0);
    }
    
    private void GoBack()    
    {
        robot.TurnRight();
        robot.TurnRight();
        robot.Move();
        robot.TurnRight();
        robot.TurnRight();
    }
    
    private void Backtrack(int row, int col, int direction)
    {
        robot.Clean();
        visited.Add((row, col));
        
        for(int i = 0; i < 4; i++)
        {
            int newD = (direction + i) % 4;
            int newRow = row + directions[newD].Item1;
            int newCol = col + directions[newD].Item2;
            
            if(!visited.Contains((newRow, newCol)) && robot.Move())
            {
                Backtrack(newRow, newCol, newD);
                GoBack();
            }
            
            robot.TurnRight();
            
        }
        
        
    }
}