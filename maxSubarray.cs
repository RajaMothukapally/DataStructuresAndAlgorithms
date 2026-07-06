public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int currSum = nums[0];
        int j=1;
        int i=0;

        while(j<nums.Length)
        {
            currSum = Math.Max(nums[j], currSum+nums[j]);
            maxSum = Math.Max(maxSum, currSum);
            j++;
        }
        return maxSum;
    }
}
