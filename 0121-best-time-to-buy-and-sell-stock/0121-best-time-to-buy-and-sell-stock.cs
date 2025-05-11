public class Solution {
    public int MaxProfit(int[] prices) {
        int n=prices.Length;
        if(n==1)return 0;
        int[] maxNext=new int[n];
        maxNext[n-1]=prices[n-1];
        int mx=0;
        for(int i=n-2;i>=0;i--)
        {
            maxNext[i]=Math.Max(maxNext[i+1],prices[i]);
            mx=Math.Max(mx,maxNext[i]-prices[i]);
        }
        return mx;
    }
}