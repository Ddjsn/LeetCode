using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    //1366. 通过投票对团队排名
    //https://leetcode-cn.com/problems/rank-teams-by-votes/
    public class T1366
    {
        public static string RankTeams(string[] votes)
        {
            var userList = votes[0].ToCharArray();
            var userMap = userList.ToDictionary(x => x, x => new int[userList.Length]);
            foreach (var item in votes)
            {
                var itemList = item.ToCharArray();
                for (var i = 0; i < itemList.Length; i++)
                {
                    userMap[itemList[i]][i]++;
                }
            }
            var str = string.Empty;
            for (var i=0;i<userList.Length - 1;i++)
            {
                for(var j=0;j<userList.Length - i -1;j++)
                {
                    if(Compare(new KeyValuePair<char, int[]>(userList[j], userMap[userList[j]]), new KeyValuePair<char, int[]>(userList[j + 1], userMap[userList[j+1]])) < 0)
                    {
                        var temp = userList[j];
                        userList[j] = userList[j + 1];
                        userList[j + 1] = temp;
                    }
                }
            }
            return new string(userList);
        }

        public static int Compare(KeyValuePair<char, int[]> t1, KeyValuePair<char, int[]> t2)
        {
            for(var i = 0; i < t1.Value.Length; i++)
            {
                if(t1.Value[i] > t2.Value[i])
                {
                    return 1;
                }
                else if(t1.Value[i] < t2.Value[i])
                {
                    return -1;
                }
            }

            return t2.Key.CompareTo(t1.Key);
        }
    }
}
