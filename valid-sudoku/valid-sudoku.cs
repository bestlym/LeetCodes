public class Solution {
    public bool IsValidSudoku(char[][] board) {
        if(board == null || board[0].Length < 9 || board.Length < 9)
            throw new ArgumentException("Invalid Input");
        
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];
                
        for(int i=0; i < 9; i++){
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }
        
        for(int row=0; row < 9; row++)
        {
            for(int col=0; col < 9; col++)
            {
                if(board[row][col] != '.')
                {
                    if(rows[row].Contains(board[row][col]) || cols[col].Contains(board[row][col]))
                    {
                        return false;
                    } else {
                        rows[row].Add(board[row][col]);
                        cols[col].Add(board[row][col]);                    
                    }
                }
            }
        }
        
        for(int box=0; box < 9; box++)
        {
            for(int row=0; row < 3; row++)
            {
                for(int col=0; col<3; col++)
                {
                    
                    int boxRow = row + 3 * (box / 3);                    
                    int boxCol = col + 3 * (box % 3);
                    if(board[boxRow][boxCol] != '.')
                    {
                        if(boxes[box].Contains(board[boxRow][boxCol]))
                        {
                            return false;
                        } else {
                            boxes[box].Add(board[boxRow][boxCol]);
                        }                        
                    }                        
                }
            }
        }
        
        return true;
    }
}