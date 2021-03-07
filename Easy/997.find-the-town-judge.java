/*
 * @lc app=leetcode id=997 lang=java
 *
 * [997] Find the Town Judge
 */

// @lc code=start
class Solution {
    public int findJudge(int N, int[][] trust) {
        if (N == 1)
        {
            return 1;
        }
        
        int[] trusted = new int[N+1];
        int[] truster = new int[N+1];
        
        for (int[] arr : trust)
        {
            trusted[arr[1]]++;
            truster[arr[0]]++;
        }
        
        for (int i=1; i<=N; i++)
        {
            if (trusted[i] == N-1 && truster[i] == 0)
            {
                return i;
            }
        }
        
        return -1;
    }
}
// @lc code=end

