public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals == null || intervals.Length == 0)
            return new int[0][];
        Array.Sort(intervals,(a, b) => a[0].CompareTo(b[0]));
        List<int[]>ans=new List<int[]>();
        int L=intervals[0][0];
        int R=intervals[0][1];
        for(int i=1;i<intervals.Length;i++)
        {
            if(intervals[i][0]<=R)
            {
                if(intervals[i][1]>R)R=intervals[i][1];
            }
            else 
            {
                ans.Add(new int[]{L,R});
                L=intervals[i][0];
                R=intervals[i][1];
            }
        }
        ans.Add(new int[]{L,R});
        // int[][]res=new int[ans.Count][];
        // int idx=0;
        // foreach(var i in ans)
        // {
        //     res[idx]=new int[2];
        //     res[idx][0]=i[0];
        //     res[idx++][1]=i[1];
        // }
        return ans.ToArray();
    }
}