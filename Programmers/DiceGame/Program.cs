using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(2, 2, 3, 5));
        }
    }

    public class Solution
    {
        public int solution(int a, int b, int c, int d)
        {
            Dictionary<int, int> sameDic = new Dictionary<int, int>();
            sameDic.Add(a, 1);

            if (!sameDic.ContainsKey(b))
            {
                sameDic.Add(b, 1);
            }
            else
            {
                sameDic[b] += 1;
            }

            if (!sameDic.ContainsKey(c))
            {
                sameDic.Add(c, 1);
            }
            else
            {
                sameDic[c] += 1;
            }

            if (!sameDic.ContainsKey(d))
            {
                sameDic.Add(d, 1);
            }
            else
            {
                sameDic[d] += 1;
            }

            int[] vals = sameDic.Values.ToArray();
            int[] keys = sameDic.Keys.ToArray();
            Array.Sort(vals, (x, y) => y.CompareTo(x));

            switch (sameDic.Count)
            {
                case 1:
                    return 1111 * a;

                case 2:
                    if (vals[0] == vals[1])
                    {
                        return (keys[0] + keys[1]) * Math.Abs(keys[0] - keys[1]);
                    }
                    else
                    {
                        List<int> tempList = new List<int>(keys);
                        int key = sameDic.FirstOrDefault(x => x.Value == 3).Key;
                        tempList.Remove(key);
                        return (key * 10 + tempList[0]) * (key * 10 + tempList[0]);
                    }

                case 3:
                    List<int> keyList = new List<int>();

                    foreach (KeyValuePair<int, int> pair in sameDic)
                    {
                        if (pair.Value == 1)
                        {
                            keyList.Add(pair.Key);
                        }
                    }
                    return keyList[0] * keyList[1];

                case 4:
                    return keys.Min();
            }

            return -1;
        }
    }
}
