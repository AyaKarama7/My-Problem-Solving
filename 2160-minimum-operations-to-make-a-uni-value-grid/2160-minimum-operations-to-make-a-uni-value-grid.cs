using System;
using System.Collections.Generic;

public class Solution {
    public int MinOperations(int[][] grid, int x) {
        List<int> values = new List<int>();
        int m = grid.Length, n = grid[0].Length;
        
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                values.Add(grid[i][j]);
            }
        }

        int remainder = values[0] % x;
        foreach (int num in values) {
            if (num % x != remainder) {
                return -1;
            }
        }
        values.Sort();
        int median = values[values.Count / 2]; 
        int operations = 0;
        foreach (int num in values) {
            operations += Math.Abs(num - median) / x;
        }

        return operations;
    }
}
