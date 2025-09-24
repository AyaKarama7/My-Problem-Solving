public class Solution {
    public int Jump(int[] nums) {
        int[] dp=Enumerable.Repeat(10001,nums.Length).ToArray();
        return solve(nums,dp,0);
    }
    int solve(int[]nums,int[]dp,int pos)
    {
        if(pos>=nums.Length-1)return 0;
        if(dp[pos]!=10001)return dp[pos];
        for(int i=1;i<=nums[pos];i++)
        {
            dp[pos]=Math.Min(dp[pos],solve(nums,dp,pos+i)+1);
        }
        return dp[pos];
    }
}