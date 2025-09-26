public class Solution {
    IList<IList<int>> grid;
    public int MinimumTotal(IList<IList<int>> triangle) {
        int n=triangle.Count;
        int[,] dp = new int[n + 1, n + 1];
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                dp[i, j] = int.MaxValue;
            }
        }
        grid=triangle;
        return FindMin(dp,n,0,0);
    }
    public int FindMin(int[,]dp,int n,int i,int j)
    {
        if(i==n-1)return grid[i][j];
        if(dp[i,j]!=int.MaxValue)return dp[i,j];
        dp[i,j]= Math.Min(FindMin(dp,n,i+1,j)+grid[i][j],FindMin(dp,n,i+1,j+1)+grid[i][j]);
        return dp[i,j];
    }
}