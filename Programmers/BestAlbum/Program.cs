using System;
using System.Collections.Generic;
using System.Linq;

namespace BestAlbum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] genres = { "classic", "pop", "classic", "classic", "pop" };
            int[] plays = { 500, 600, 150, 800, 2500 };
            int[] result = solution.solution(genres, plays);
            Console.WriteLine(string.Join(", ", result));
        }
    }

    public class Solution
    {
        public int[] solution(string[] genres, int[] plays)
        {
            Dictionary<string, List<int>> genPlaysDic = new Dictionary<string, List<int>>();
            Dictionary<string, int> genPlaySumsDic = new Dictionary<string, int>();

            for (int i = 0; i < genres.Length; i++)
            {
                if (!genPlaysDic.ContainsKey(genres[i]))
                {
                    genPlaysDic.Add(genres[i], new List<int>());
                }
                genPlaysDic[genres[i]].Add(i);
                if (!genPlaySumsDic.ContainsKey(genres[i]))
                {
                    genPlaySumsDic.Add(genres[i], plays[i]);
                }
                else
                {
                    genPlaySumsDic[genres[i]] += plays[i];
                }
            }

            SortedList<int, string> reverseGenPlaySumDic = new SortedList<int, string>(genPlaySumsDic.Count);

            foreach (var kvp in genPlaySumsDic)
            {
                reverseGenPlaySumDic.Add(kvp.Value, kvp.Key);
            }

            List<int> answerList = new List<int>();

            while (reverseGenPlaySumDic.Count > 0)
            {
                string genre = reverseGenPlaySumDic.Values.Last();
                reverseGenPlaySumDic.RemoveAt(reverseGenPlaySumDic.Count - 1);

                List<int> playsList = genPlaysDic[genre];
                var sortedPlays = playsList.OrderByDescending(i => plays[i]).Take(2);
                answerList.AddRange(sortedPlays);
            }

            int[] answer = answerList.ToArray();
            return answer;
        }
    }
}
