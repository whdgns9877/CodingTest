using System;

namespace ArrangeStringMyMind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] strings = { "sun", "bed", "car" };
            Console.WriteLine(solution.solution(strings, 1));
        }
    }

    public class Solution
    {
        public string[] solution(string[] strings, int n)
        {
            string[] answer = new string[strings.Length];

            for (int i = 0; i < strings.Length - 1; i++)
            {
                for (int j = i + 1; j < strings.Length; j++)
                {
                    // 해당 인덱스의 char비교
                    if (strings[i][n].CompareTo(strings[j][n]) > 0)
                    {
                        Swap(ref strings, i, j);
                    }
                    else if (strings[i][n] == strings[j][n])
                    {
                        if (strings[i].CompareTo(strings[j]) > 0)
                        {
                            Swap(ref strings, i, j);
                        }
                    }
                }
            }

            answer = strings;

            return answer;
        }

        private void Swap(ref string[] arr, int idx1, int idx2)
        {
            string temp = arr[idx2];
            arr[idx2] = arr[idx1];
            arr[idx1] = temp;
        }
    }
}
