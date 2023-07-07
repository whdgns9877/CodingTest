using System;

namespace Fatigue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[,] dungeons = { { 80, 20 }, { 50, 40 }, { 30, 10 } };
            Console.WriteLine(solution.solution(80, dungeons));
        }
    }

    public class Solution
    {
        private bool[] visit;
        private int[,] dungeons;
        private int max = 0;

        public int solution(int k, int[,] dungeons)
        {
            ints.Add(k);
            this.dungeons = dungeons;
            // 해당 노드를 방문했는지를 나타낼 배열
            visit = new bool[dungeons.GetLength(0)];

            for (int i = 0; i < dungeons.GetLength(0); i++)
            {
                // 현재 피로도가 해당 던전의 최소 피로도보다 높다면 DFS 실행
                if (k >= dungeons[i,0])
                {
                    // i번째 기준으로 DFS실행
                    DFS(i, k, 1);
                }
            }
            return max;
        }

        private void DFS(int cur, int tired, int depth)
        {
            // cur번째 던전에 방문
            visit[cur] = true;
            // 해당 던전의 피로도만큼 현재 피로도 차감
            tired -= dungeons[cur,1];
            
            for (int i = 0; i < dungeons.GetLength(0); i++)
            {
                // 현재 던전들중 방문하지 않았고 해당 던전의 최소 피로도 보다 남아있는 피로도가 높다면
                if (!visit[i] && dungeons[i,0] <= tired)
                {
                    // 해당 던전을 기준으로 DFS 하고 경우의수 1 증가
                    DFS(i, tired, depth + 1);
                }
            }
            // 기존에 max 값과 현재(cur번째)의 경우의수를 비교하여 더 큰값을 max에 저장
            max = Math.Max(depth, max);
            // 다른 경우의 수를 위해 방문을 다시 false로 
            visit[cur] = false;
        }
    }
}
