public class Solution {
    public int NumIslands(char[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;

        int count = 0;

        for (int r = 0; r < rows; r++){
            for (int c = 0; c < cols; c++){
                if(grid[r][c] == '1'){
                    count += 1;
                    DFS(grid, r, c, rows, cols);
                }
            }
        }
        return count;

    }

    private void DFS(char[][] grid, int r, int c, int rows, int cols)
    {
        if (r < 0 || c < 0 || r >= rows || c >= cols)
            return;

        if (grid[r][c] == '0')
            return;

        grid[r][c] = '0';

        DFS(grid, r + 1, c, rows, cols); 
        DFS(grid, r - 1, c, rows, cols); 
        DFS(grid, r, c + 1, rows, cols); 
        DFS(grid, r, c - 1, rows, cols); 
    }
}
