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
       Array.Sort(nums);
       int l=0,r=nums.Length-1;
       while(l<r)
       {
        int t=nums[l]+nums[r];
        if(t==target)
        {
            if(nums[l]==nums[r])
            {
                res[0]=map[nums[l]][0];
                res[1]=map[nums[r]][1];
                return res;
            }
            else
            {
                res[0]=map[nums[l]][0];
                res[1]=map[nums[r]][0];
                return res;
            }
        }
        else if(t>target)r--;
        else l++;
       }
       return res;
    }
}