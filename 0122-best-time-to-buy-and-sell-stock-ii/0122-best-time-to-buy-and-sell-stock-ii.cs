public class Solution {
    public int MaxProfit(int[] prices) {
        int profit=0,n=prices.Length;
        for(int i=1;i<n;i++)
        {
            if(prices[i]>prices[i-1])profit+=prices[i]-prices[i-1];
        }
        return profit;
    }
}