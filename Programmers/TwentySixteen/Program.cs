using System;

namespace TwentySixteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(5, 5));
        }
    }

    public class Solution
    {
        public string solution(int a, int b)
        {
            string[] days = { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };
            int dayNum = b - 1;

            switch (a)
            {
                case 2:
                    dayNum += 31;
                    break;

                case 3:
                    dayNum += 60;
                    break;

                case 4:
                    dayNum += 91;
                    break;

                case 5:
                    dayNum += 121;
                    break;

                case 6:
                    dayNum += 152;
                    break;

                case 7:
                    dayNum += 182;
                    break;

                case 8:
                    dayNum += 213;
                    break;

                case 9:
                    dayNum += 244;
                    break;

                case 10:
                    dayNum += 274;
                    break;

                case 11:
                    dayNum += 305;
                    break;

                case 12:
                    dayNum += 335;
                    break;
            }

            return days[(dayNum % 7)];
        }
    }
}
