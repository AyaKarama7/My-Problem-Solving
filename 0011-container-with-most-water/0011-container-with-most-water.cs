public class Solution {
    public int MaxArea(int[] height) {
        int n=height.Length;
        int l=1,r=n,mx=-1;
        while(l<r)
        {
            int area=(r-l)*Math.Min(height[r-1],height[l-1]);
            mx=Math.Max(mx,area);
            if(height[r-1]<height[l-1])r--;
            else l++;
        }
        return mx;
    }
}