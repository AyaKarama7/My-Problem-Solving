public class Solution {
    public int MaxProfit(int[] prices) {
        int mx=0,mn=prices[0];
        for(int i=1;i<prices.Length;i++)
        {
            if(prices[i]-mn>mx)mx=prices[i]-mn;
            else if(prices[i]<mn)mn=prices[i];
        }
        return mx;
    }
}