using System.Collections.Generic;
using System.Linq;

public class Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] picks = { 1, 3, 2 };
            string[] minerals = { "diamond", "diamond", "diamond", "iron", "iron", "diamond", "iron", "stone";
            solution.solution(picks, minerals);
        }
    }

    private class Mineral
    {
        public int Diamond { get; private set; }
        public int Iron { get; private set; }
        public int Stone { get; private set; }

        public Mineral(int diamond, int iron, int stone)
        {
            Diamond = diamond;
            Iron = iron;
            Stone = stone;
        }
    }

    private static int[][] scoreBoard;
    private static List<Mineral> list;

    public int solution(int[] picks, string[] minerals)
    {
        int answer = 0;

        scoreBoard = new int[][] { new int[] { 1, 1, 1 }, new int[] { 5, 1, 1 }, new int[] { 25, 5, 1 } };

        int totalPicks = picks.Sum();
        list = new List<Mineral>();
        for (int i = 0; i < minerals.Length; i += 5)
        {
            if (totalPicks == 0) break;

            int dia = 0, iron = 0, stone = 0;
            for (int j = i; j < i + 5; j++)
            {
                if (j == minerals.Length) break;

                string mineral = minerals[j];
                int val = mineral.Equals("iron") ? 1 :
                    mineral.Equals("stone") ? 2 : 0;

                dia += scoreBoard[0][val];
                iron += scoreBoard[1][val];
                stone += scoreBoard[2][val];
            }

            list.Add(new Mineral(dia, iron, stone));
            totalPicks--;
        }

        list.Sort((o1, o2) => o2.Stone.CompareTo(o1.Stone));
        foreach (Mineral m in list)
        {
            int dia = m.Diamond;
            int iron = m.Iron;
            int stone = m.Stone;

            if (picks[0] > 0)
            {
                answer += dia;
                picks[0]--;
                continue;
            }
            if (picks[1] > 0)
            {
                answer += iron;
                picks[1]--;
                continue;
            }
            if (picks[2] > 0)
            {
                answer += stone;
                picks[2]--;
                continue;
            }
        }

        return answer;
    }
}
