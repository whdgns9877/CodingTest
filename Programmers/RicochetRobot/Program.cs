using System;
using System.Collections.Generic;

namespace RicochetRobot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] board = { "...D..R", ".D.G...", "....D.D", "D....D.", "..D...." };
            Console.WriteLine(solution.solution(board));
        }
    }

    public class Solution
    {
        // 순서 쌍으로                 하  우 상 좌
        private readonly int[] dy = { -1, 0, 1, 0 };
        private readonly int[] dx = { 0, 1, 0, -1 };

        public int solution(string[] board)
        {
            var start = FindStartNode(board);
            return BFS(
                board,
                new bool[board.Length, board[0].Length],
                new[] { start.Item1, start.Item2, 0 }
            );
        }

        private int BFS(string[] board, bool[,] visited, int[] node)
        {
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                int[] current = queue.Dequeue();
                int cRow = current[0];
                int cCol = current[1];
                int cCnt = current[2];
                if (board[cRow][cCol] == 'G')
                    return cCnt;
                for (var i = 0; i < 4; i++)
                {
                    var next = FindNextNode(board, cRow, cCol, dy[i], dx[i]);
                    if (next != Tuple.Create(cRow, cCol) && !visited[next.Item1, next.Item2])
                    {
                        queue.Enqueue(new[] { next.Item1, next.Item2, current[2] + 1 });
                        visited[next.Item1, next.Item2] = true;
                    }
                }
            }
            return -1;
        }

        private Tuple<int, int> FindNextNode(string[] board, int startRow, int startCol, int dy, int dx)
        {
            var row = startRow;
            var column = startCol;
            // 장애물이 나오거나 각 맵의 끝이 나올때까지 해당 방향으로 확인
            while (true)
            {
                if (row + dy == -1 || row + dy == board.Length)
                    return Tuple.Create(row, column);
                if (column + dx == -1 || column + dx == board[0].Length)
                    return Tuple.Create(row, column);
                if (board[row + dy][column + dx] == 'D')
                    return Tuple.Create(row, column);
                row += dy;
                column += dx;
            }
        }

        private Tuple<int, int> FindStartNode(string[] board)
        {
            for (var row = 0; row < board.Length; row++)
            {
                for (var column = 0; column < board[0].Length; column++)
                {
                    if (board[row][column] == 'R')
                        return Tuple.Create(row, column);
                }
            }
            return Tuple.Create(0, 0);
        }
    }
}
