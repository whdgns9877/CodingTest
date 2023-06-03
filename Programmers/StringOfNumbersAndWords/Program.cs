using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringOfNumbersAndWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "2three45sixseven";
            solution.solution(s);
        }
    }

    public class Solution
    {
        public int solution(string s)
        {
            int answer = 0;

            // 원하는 대체 값들을 정의합니다.
            Dictionary<string, string> replacements = new Dictionary<string, string>()
            {
                {"zero", "0"},
                {"one","1"},
                {"two","2"},
                {"three", "3"},
                {"four", "4"},
                {"five", "5"},
                {"six", "6"},
                {"seven", "7"},
                {"eight", "8"},
                {"nine", "9"}
             };

            // 문자열에서 대체해야 할 부분을 순회하면서 대체합니다.
            foreach (var replacement in replacements)
            {
                s = s.Replace(replacement.Key, replacement.Value);
            }

            answer = int.Parse(s);

            return answer;
        }
    }
}
