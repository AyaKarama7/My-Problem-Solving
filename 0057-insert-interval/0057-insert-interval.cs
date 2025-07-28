public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        //check overlap
        //sort 
        List<int[]>ans=new List<int[]>();
        foreach(var i in intervals)
        {
            //maxL <= minR
            int maxL=Math.Max(i[0],newInterval[0]);//4 
            int minR=Math.Min(i[1],newInterval[1]);//2
            if(maxL<=minR)
            {
                newInterval[0]=Math.Min(i[0],newInterval[0]);
                newInterval[1]=Math.Max(i[1],newInterval[1]);
            }
            else 
            {
                ans.Add(i);
            }
            //newInterval=i;
        }
        ans.Add(newInterval);
        int[][]res=ans.ToArray();
        Array.Sort(res,(a,b)=>a[0].CompareTo(b[0]));
        return res;
    }
}