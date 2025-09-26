class Solution {
public:
    int triangleNumber(vector<int>& nums) {
        int n=nums.size();
        int ans=0;
        sort(nums.begin(),nums.end());
        for(int i=0;i<n;i++)
        {
            for(int j=i+1;j<n-1;j++)
            {
                int sum=nums[i]+nums[j];
                int idx=lower_bound(nums.begin(), nums.end(), sum) - nums.begin();
                ans+=(max(idx-(j+1),0));
            }
        }
        return ans;
    }
};