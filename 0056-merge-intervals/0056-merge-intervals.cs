public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals,(a, b) => a[0]-b[0]);
        List<int[]>ans=new List<int[]>();
        int L=intervals[0][0];
        int R=intervals[0][1];
        for(int i=1;i<intervals.Length;i++)
        {
            int a=intervals[i][0];
            int b=intervals[i][1];
            if(a<=R)
            {
                if(b>R)R=b;
            }
            else 
            {
                ans.Add(new int[]{L,R});
                L=a;
                R=b;
            }
        }
        ans.Add(new int[]{L,R});
        return ans.ToArray();
    }
}