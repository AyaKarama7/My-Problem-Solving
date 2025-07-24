public class Solution {
    public int RemoveDuplicates(int[] nums) {
        Dictionary<int,int> freq=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(freq.ContainsKey(nums[i]))
            freq[nums[i]]++;
            else 
            {
                freq[nums[i]]=1;
            }
        }
        int idx=0;
        foreach(var it in freq)
        {
            int l=Math.Min(2,it.Value);
            while(l-->0)nums[idx++]=it.Key;
        }
        return idx;
    }
}