public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var newList = new List<IList<int>>();
        for(int i=0;i<nums.Length;i++)
        {
            int j=i+1;
            int k = nums.Length-1;

            if(i > 0 && nums[i] == nums[i-1])
            {
                continue;
            }
            while(j < k)
            {
                int sum = nums[i]+nums[j]+nums[k];
                if(sum == 0)
                {
                    newList.Add(new List<int>{nums[i], nums[j], nums[k]});

                    j++;k--;

                    while(j<k && nums[j] == nums[j-1])
                    {
                        j++;
                    }

                    while(j<k && nums[k] == nums[k+1])
                    {
                        k--;
                    }
                }
                else if (sum > 0)
                {
                    k--;
                }
                else
                {
                    j++;
                }
            }
        }
        return newList;
    }
}
