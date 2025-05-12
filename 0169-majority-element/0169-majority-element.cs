public class Solution {
    public int MajorityElement(int[] nums) {
        int k=nums[0],mx=1;
        Dictionary<int,int>freq=new Dictionary<int,int>();
        foreach(var i in nums)
        {
            if(freq.ContainsKey(i))
            {
                freq[i]++;
                if(freq[i]>mx)
                {
                    mx=freq[i];
                    k=i;
                }
            }
            else freq[i]=1;
        }
        return k;
    }
}