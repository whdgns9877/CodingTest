using System;
using System.Collections.Generic;

namespace VisitLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string dirs = "LULLLLLLU";
            Console.WriteLine(solution.solution(dirs));
        }
    }

    public class Solution
    {
        public int solution(string dirs)
        {
            int[] dx = { 0, -1, 1, 0 };
            int[] dy = { 1, 0, 0, -1 };

            int curX = 0;
            int curY = 0;

            HashSet<Tuple<Tuple<int, int>, Tuple<int, int>>> edge = new HashSet<Tuple<Tuple<int, int>, Tuple<int, int>>>();

            Dictionary<char, int> direction = new Dictionary<char, int>();

            direction.Add('U', 0);
            direction.Add('L', 1);
            direction.Add('R', 2);
            direction.Add('D', 3);

            foreach (char c in dirs)
            {
                int prevX = curX;
                int prevY = curY;

                curX += dx[direction[c]];
                curY += dy[direction[c]];

                if (IsInValidPosition(curX, curY))
                {
                    Tuple<int, int> startCoord;
                    Tuple<int, int> endCoord;

                    if (curX < prevX || curY < prevY)
                    {
                        startCoord = Tuple.Create(curX, curY);
                        endCoord = Tuple.Create(prevX, prevY);
                    }
                    else
                    {
                        startCoord = Tuple.Create(prevX, prevY);
                        endCoord = Tuple.Create(curX, curY);
                    }

                    Tuple<Tuple<int, int>, Tuple<int, int>> edgeTuple = Tuple.Create(startCoord, endCoord);
                    edge.Add(edgeTuple);
                }
                else
                {
                    curX -= dx[direction[c]];
                    curY -= dy[direction[c]];
                }
            }

            return edge.Count;
        }

        private bool IsInValidPosition(int x, int y)
        {
            return (x >= -5 && x <= 5 && y >= -5 && y <= 5);
        }
    }
}
