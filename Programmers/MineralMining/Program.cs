using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MineralMining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] picks = { 0, 1, 1 };
            string[] minerals = { "diamond", "diamond", "diamond", "diamond", "diamond", "iron", "iron", "iron", "iron", "iron", "diamond" };
            solution.solution(picks, minerals);
        }
    }

    public class Solution
    {
        public int solution(int[] picks, string[] minerals)
        {
            int answer = 0;

            string curPick = "";

            int idx = 0;

            for (int i = 0; i < 3; ++i)
            {
                switch (i)
                {
                    case 0:
                        curPick = "dia";
                        break;

                    case 1:
                        curPick = "iron";
                        break;

                    case 2:
                        curPick = "stone";
                        break;
                }

                int remainPick = picks[i];

                while (remainPick > 0)
                {
                    switch (curPick)
                    {
                        case "dia":
                            answer++;
                            break;

                        case "iron":
                            switch (minerals[idx])
                            {
                                case "diamond":
                                    answer += 5;
                                    break;

                                case "iron":
                                    answer++;
                                    break;

                                case "stone":
                                    answer++;
                                    break;
                            }
                            break;

                        case "stone":
                            switch (minerals[idx])
                            {
                                case "diamond":
                                    answer += 25;
                                    break;

                                case "iron":
                                    answer += 5;
                                    break;

                                case "stone":
                                    answer++;
                                    break;
                            }
                            break;
                    }
                    idx++;
                    remainPick--;
                }
            }

            return answer;
        }
    }
}
