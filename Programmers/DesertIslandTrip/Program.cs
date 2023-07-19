using System;
using System.Collections.Generic;

namespace DesertIslandTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] maps = { "X591X", "X1X5X", "X231X", "1XXX1" };
            Console.WriteLine(string.Join(", ", solution.solution(maps)));
        }
    }

    public class Solution
    {
        string[] maps;
        bool[,] isVisited;
        int[] dx = { -1, 0, 1, 0 };
        int[] dy = { 0, 1, 0, -1 };
        int maxRow;
        int maxCol;
        const char WATER = 'X';

        public int[] solution(string[] maps)
        {
            List<int> answer = new List<int>();
            this.maps = maps;
            maxRow = maps.Length;
            maxCol = maps[0].Length;
            isVisited = new bool[maxRow, maxCol];

            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    int survive = 0;
                    // 현재 확인하려는 곳이 물(X)이 아니고 아직 확인해보지 않은 곳이라면
                    if (maps[i][j] != WATER && !isVisited[i, j])
                    {
                        survive = DFS(i, j);
                        answer.Add(survive);
                    }
                }
            }

            if(answer.Count == 0)
            {
                answer.Add(-1);
                return answer.ToArray();
            }

            answer.Sort();

            return answer.ToArray();
        }

        private int DFS(int x, int y)
        {
            if (isVisited[x, y])
            {
                return 0;
            }

            isVisited[x, y] = true;
            int totalSurvive = int.Parse(maps[x][y].ToString());

            for (int k = 0; k < 4; k++)
            {
                int nx = x + dx[k];
                int ny = y + dy[k];

                if (IsValidPosition(nx, ny) && maps[nx][ny] != WATER)
                {
                    totalSurvive += DFS(nx, ny);
                }
            }

            return totalSurvive;
        }

        private bool IsValidPosition(int x, int y)
        {
            return (x >= 0 && x < maxRow && y >= 0 && y < maxCol);
        }
    }
}
