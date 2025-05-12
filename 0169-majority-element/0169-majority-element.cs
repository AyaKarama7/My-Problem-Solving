public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int>freq=new Dictionary<int,int>();
        foreach(var i in nums)
        {
            if(freq.ContainsKey(i))
            {
                freq[i]++;
            }
            else freq[i]=1;
        }
        foreach(var i in freq)
        {
            if(i.Value>nums.Length/2)return i.Key;
        }
        return 0;
    }
}