using System;
using System.Collections.Generic;

namespace ShortestDistanceInGameMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[,] maps = { { 1, 0, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 1 }, { 1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 1 } };
            Console.WriteLine(solution.solution(maps));
        }
    }

    public class Solution
    {
        int[,] maps;
        int[] dx = { -1, 0, 1, 0 };
        int[] dy = { 0, -1, 0, 1 };

        int row;
        int col;

        public int solution(int[,] maps)
        {
            row = maps.GetLength(0);
            col = maps.GetLength(1);
            this.maps = maps;

            if (maps[row - 1, col - 1] == 0)
            {
                return -1;
            }

            int[,] distances = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    distances[i, j] = int.MaxValue;
                }
            }

            distances[0, 0] = 1;

            Queue<Coord> queue = new Queue<Coord>();
            queue.Enqueue(new Coord(0, 0));

            while (queue.Count > 0)
            {
                Coord current = queue.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int nx = current.X + dx[i];
                    int ny = current.Y + dy[i];

                    if (IsValidPosition(nx, ny) && maps[nx, ny] == 1 && distances[nx, ny] > distances[current.X, current.Y] + 1)
                    {
                        distances[nx, ny] = distances[current.X, current.Y] + 1;
                        queue.Enqueue(new Coord(nx, ny));
                    }
                }
            }

            return distances[row - 1, col - 1] == int.MaxValue ? -1 : distances[row - 1, col - 1];
        }

        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < row && y >= 0 && y < col;
        }
    }

    public class Coord
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
