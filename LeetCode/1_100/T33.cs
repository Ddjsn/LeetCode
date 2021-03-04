using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode._1_100
{
    /// <summary>
    /// 33. 搜索旋转排序数组 
    /// https://leetcode-cn.com/problems/search-in-rotated-sorted-array/
    /// </summary>
    public class T33
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Search(int[] nums, int target)
        {
            return My(nums, target);
        }
        /// <summary>
        /// 我的 时间复杂度 Ο(n)
        /// </summary>
        /// <returns></returns>
        public int My(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if(target == nums[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public int Other(int[] nums, int target)
        {
            return 0;
        }
    }
}