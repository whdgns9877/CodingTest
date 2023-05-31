using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] players = new string[] { "mumu", "soe", "poe", "kai", "mine" };
            string[] callings = new string[] { "kai", "kai", "mine", "mine" };
            solution.solution(players, callings);
        }
    }

    public class Solution
    {
        public string[] solution(string[] players, string[] callings)
        {
            for (int i = 0; i < callings.Length; ++i)
            {
                int idx = Array.IndexOf(players, callings[i]);
                if (idx > 0)
                {
                    Array.Reverse(players, idx - 1, 2);
                }
            }

            return players;
        }
    }
}
