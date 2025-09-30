public class Solution {
    int n;
    int[,] dp;
    int[] nums;
    public int MinScoreTriangulation(int[] nums) {
        n=nums.Length;
        if(n==3)return nums[0]*nums[1]*nums[2];
        dp=new int[n,n];
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)dp[i,j]=int.MaxValue;
        }
        this.nums=nums;
        return DP(0,n-1);
    }
    int DP(int i,int j)
    {
        if(i+2>j)return 0;
        if(i+2==j)return nums[i]*nums[i+1]*nums[i+2];
        if(dp[i,j]!=int.MaxValue)return dp[i,j];
        for(int k=i+1;k<j;k++)
        {
            dp[i,j]=Math.Min(dp[i,j],nums[i]*nums[k]*nums[j]+DP(i,k)+DP(k,j));
        }
        return dp[i,j];
    }
    
}