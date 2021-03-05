using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode._1_100
{
    /// <summary>
    /// 121. 买卖股票的最佳时机
    /// https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    public class T121
    {
        public int MaxProfit(int[] prices)
        {
            if(prices.Length <= 1)
            {
                return 0;
            }
            int mapProfit = 0;
            int min = prices[0];
            int max = prices[0];
            for(int i=1; i< prices.Length; i++)
            {
                if(min > prices[i])
                {
                    min = prices[i];
                    max = min;
                }
                else if(max < prices[i])
                {
                    max = prices[i];
                    mapProfit =  max - min > mapProfit ? max-min : mapProfit;
                }
            }
            return mapProfit;
        }
    }
}