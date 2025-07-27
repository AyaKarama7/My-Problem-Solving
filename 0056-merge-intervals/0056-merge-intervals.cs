public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals,(a, b) => a[0].CompareTo(b[0]));
        List<List<int>>ans=new List<List<int>>();
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
                ans.Add(new List<int>{L,R});
                L=a;
                R=b;
            }
        }
        ans.Add(new List<int>{L,R});
        int s=ans.Count;
        int[][]res=new int[s][];
        int idx=0;
        foreach(var i in ans)
        {
            res[idx]=new int[2];
            res[idx][0]=i[0];
            res[idx++][1]=i[1];
        }
        return res;
    }
}