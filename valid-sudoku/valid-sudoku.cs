public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        if(board == null || board.Length != 9 || board[0].Length != 9)
            throw new ArgumentException("Invalid Input.");
        
        HashSet<char>[] rowSet = new HashSet<char>[9];
        HashSet<char>[] colSet = new HashSet<char>[9];
        HashSet<char>[] boxSet = new HashSet<char>[9];
        for(int i = 0; i < 9; i++)
        {
            rowSet[i] = new HashSet<char>();
            colSet[i] = new HashSet<char>();
            boxSet[i] = new HashSet<char>();
        }
        
        for(int row = 0; row < 9; row++)
        {
            for(int col = 0; col < 9; col++)
            {
                if(board[row][col] != '.')
                {
                    if(rowSet[row].Contains(board[row][col]) || colSet[col].Contains(board[row][col]))
                        return false;
                    else
                    {
                        rowSet[row].Add(board[row][col]);
                        colSet[col].Add(board[row][col]);
                    }
                }
            }
        }
        
        for(int box = 0; box < 9; box++)
        {
            for(int row = 0; row < 3; row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    int r = row + 3 * (box / 3);
                    int c = col + 3 * (box % 3);
                    if(board[r][c] != '.')
                    {
                        if(boxSet[box].Contains(board[r][c]))
                            return false;
                        else
                            boxSet[box].Add(board[r][c]);
                    }
                }
            }
        }
        
        return true;
    }
}