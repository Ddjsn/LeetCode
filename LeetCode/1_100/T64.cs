using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode._1_100
{
    /// <summary>
    /// 64. 最小路径和
    /// https://leetcode-cn.com/problems/minimum-path-sum/
    /// </summary>
    public class T64
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int MinPathSum(int[][] grid)
        {
            return My(grid);
        }
        /// <summary>
        /// 我的 时间复杂度 Ο(n)
        /// </summary>
        /// <returns></returns>
        public int My(int[][] grid)
        {
            var dpArr = new int[grid.Length, grid[0].Length];
            var oneLength = grid.Length;
            var twoLength = grid[0].Length;

            for (int i=0;i< oneLength; i++)
            {
                for(int ii = 0; ii < twoLength; ii++)
                {
                    if (i == 0)
                    {
                        if (ii == 0)
                        {
                            dpArr[i, ii] = grid[i][ii];
                        }
                        else
                        {
                            dpArr[i, ii] = dpArr[i, ii - 1] + grid[i][ii];
                        }
                    }
                    else if(ii == 0)
                    {
                        dpArr[i, ii] = dpArr[i-1, ii] + grid[i][ii];
                    }
                    else
                    {
                        dpArr[i, ii] = Math.Min(dpArr[i - 1, ii], dpArr[i, ii - 1]) + grid[i][ii];
                    }
                }
            }
            return dpArr[oneLength-1, twoLength-1];
        }

        public int Other(int[] nums, int target)
        {
            return 0;
        }
    }
}