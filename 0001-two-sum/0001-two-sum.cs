public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       int[] res=new int[2];
       Dictionary<int,List<int>>map=new Dictionary<int,List<int>>();
       for(int i=0;i<nums.Length;i++)
       {
        if(map.ContainsKey(nums[i]))
        {
            map[nums[i]].Add(i);
        }
        else 
        {
            map[nums[i]]=new List<int>();
            map[nums[i]].Add(i);
        }
       }
       int idx=0;
       foreach(var i in nums)
       {
        int x=target-i;
        if(!map.ContainsKey(x))idx++;
        else if(x==i&&map[i].Count==1)idx++;
        else if(x!=i)
        {
            res[0]=idx;
            res[1]=map[x][0];
            return res;
        }
        else 
        {
            res[0]=idx;
            res[1]=map[x][1];
            return res;
        }
       }
       return res;
    }
}