using System;

namespace SpiralArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(4));
        }
    }

    public class Solution
    {
        public int[,] solution(int n)
        {
            int[,] answer = new int[n, n];
            int num = 1; // 배열에 채워질 숫자
            int row = 0; // 현재 행 위치
            int col = 0; // 현재 열 위치
            int direction = 0; // 이동 방향 (0: 오른쪽, 1: 아래, 2: 왼쪽, 3: 위)

            for (int i = 0; i < n * n; i++)
            {
                answer[row, col] = num++;

                // 다음 위치 계산
                switch (direction)
                {
                    case 0: // 오른쪽으로 이동
                        col++;
                        if (col == n || answer[row, col] != 0) // 범위를 벗어나거나 이미 값이 채워진 경우
                        {
                            col--;
                            row++;
                            direction = 1; // 아래로 이동
                        }
                        break;
                    case 1: // 아래로 이동
                        row++;
                        if (row == n || answer[row, col] != 0) // 범위를 벗어나거나 이미 값이 채워진 경우
                        {
                            row--;
                            col--;
                            direction = 2; // 왼쪽으로 이동
                        }
                        break;
                    case 2: // 왼쪽으로 이동
                        col--;
                        if (col < 0 || answer[row, col] != 0) // 범위를 벗어나거나 이미 값이 채워진 경우
                        {
                            col++;
                            row--;
                            direction = 3; // 위로 이동
                        }
                        break;
                    case 3: // 위로 이동
                        row--;
                        if (row < 0 || answer[row, col] != 0) // 범위를 벗어나거나 이미 값이 채워진 경우
                        {
                            row++;
                            col++;
                            direction = 0; // 오른쪽으로 이동
                        }
                        break;
                }
            }

            return answer;
        }
    }
}
