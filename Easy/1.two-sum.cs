/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] indices = new int[2];
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(target - nums[i]))
            {
                indices[0] = i;
                indices[1] = map[target - nums[i]];
                
                return indices;
            }
            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }
        
        return indices;
    }
}
// @lc code=end

