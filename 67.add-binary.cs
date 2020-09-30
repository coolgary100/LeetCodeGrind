/*
 * @lc app=leetcode id=67 lang=csharp
 *
 * [67] Add Binary
 */

// @lc code=start
public class Solution {
    public string AddBinary(string a, string b) {
        int aLen = a.Length - 1;
        int bLen = b.Length - 1;
        int carry = 0;
        string answer = "";
        while (aLen >= 0 || bLen >= 0)
        {
            int sum = GetDigit(a, aLen--) + GetDigit(b, bLen--) + carry;
            answer = (sum % 2 == 0 ? '0' : '1') + answer;
            carry = sum / 2;
        }
        
        if (carry > 0)
        {
            answer = '1' + answer;
        }
        return answer;
    }
    
    public int GetDigit(string value, int index)
    {
        return index < 0 ? 0 : value[index] == '0' ? 0 : 1;
    }
}
// @lc code=end

