public class Solution {
    public int MajorityElement(int[] nums) {
        if(nums.Length==1)return nums[0];
        int k=nums[0];
        Dictionary<int,int>freq=new Dictionary<int,int>();
        foreach(var i in nums)
        {
            if(freq.ContainsKey(i))
            {
                freq[i]++;
                if(freq[i]>(nums.Length/2))
                {
                    k=i;
                    return k;
                }
            }
            else freq[i]=1;
            if(freq[i]>nums.Length/2)return i;
        }
        return k;
    }
}