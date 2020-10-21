/*
 * @lc app=leetcode id=118 lang=csharp
 *
 * [118] Pascal's Triangle
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> pascalTriangle = new List<IList<int>>();
        List<int> singleRow = new List<int>();
        for (int i = 0; i < numRows; i++)
        {
            singleRow.Insert(0, 1);
            for(int j = 1; j < singleRow.Count - 1; j++)
            {
                singleRow[j] = singleRow[j] + singleRow[j+1];
            }
            pascalTriangle.Add(new List<int>(singleRow));
        }
        
        return pascalTriangle;
    }
}
// @lc code=end

