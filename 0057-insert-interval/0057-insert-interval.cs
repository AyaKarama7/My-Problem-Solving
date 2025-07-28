public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        if(intervals.Length==0)return new int[][]{newInterval};
        int n=intervals.Length,L=0,R=n-1,target=newInterval[0];
        while(L<=R)
        {
            int mid=L+(R-L)/2;
            if(intervals[mid][0]<=target)L=mid+1;
            else R=mid-1;
        }
        List<int[]>ans=new List<int[]>();
        for(int i=0;i<L;i++)ans.Add(intervals[i]);
        ans.Add(newInterval);
        for(int i=L;i<n;i++)ans.Add(intervals[i]);
        List<int[]>merge=new List<int[]>();
        foreach(var i in ans)
        {
            if(merge.Count==0||merge[merge.Count-1][1]<i[0])merge.Add(i);
            else merge[merge.Count-1][1]=Math.Max(merge[merge.Count-1][1],i[1]);
        }
        return merge.ToArray();
    }
}