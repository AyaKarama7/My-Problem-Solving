public class Solution {
    public double LargestTriangleArea(int[][] points) {
        int n=points.Length;
        double Area=0;
        for(int i=0;i<n-2;i++)
        {
            for(int j=i+1;j<n-1;j++)
            {
                for(int k=j+1;k<n;k++)
                {
                    int x1 = points[i][0], y1 = points[i][1];
                    int x2 = points[j][0], y2 = points[j][1];
                    int x3 = points[k][0], y3 = points[k][1];
                    double currentArea = 0.5 * Math.Abs(x1*(y2 - y3) + x2*(y3 - y1) + x3*(y1 - y2));
                    Area = Math.Max(Area, currentArea);
                }
            }
        }
        return Area;
    }
}