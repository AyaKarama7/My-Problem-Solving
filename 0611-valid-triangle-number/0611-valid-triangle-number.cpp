class Solution {
public:
    int triangleNumber(vector<int>& nums) {
        int n=nums.size();
        int ans=0;
        sort(nums.begin(),nums.end());
        for(int i=0;i<n-2;i++)
        {
            int k=i+2;
            for(int j=i+1;j<n-1&&nums[i]!=0;j++)
            {
                int sum=nums[i]+nums[j];
                while(k<n&&sum>nums[k])k++;
                ans+=(k-j-1);
                
            }
        }
        return ans;
    }
};