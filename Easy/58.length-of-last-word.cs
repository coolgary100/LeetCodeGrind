/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 */

// @lc code=start
public class Solution {
    public int LengthOfLastWord(string s) {
        int end = s.Length - 1;
        while (end >= 0 && s[end] == ' ')
        {
            end--;
        }
        int start = end;
        while(start >= 0 && s[start] != ' ')
        {
            start --;
        }
        return end - start;
    }
}
// @lc code=end

