using System;

namespace TriangleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] answer = solution.solution(5);
            foreach (int num in answer)
            {
                Console.Write(num + ",");
            }
        }
    }

    public class Solution
    {
        int len = 0;

        public int[] solution(int n)
        {
            int[,] answer = new int[n, n];
            int num = 1; // 배열에 채워질 숫자
            int row = 0; // 현재 행 위치
            int col = 0; // 현재 열 위치
            int direction = 0; // 이동 방향 (0: 아래, 1: 오른쪽, 2: 왼쪽대각선위)
            len = GetLength(n);

            for (int i = 0; i < len; i++)
            {
                answer[row, col] = num++;

                // 다음 위치 계산
                switch (direction)
                {
                    case 0: // 아래쪽으로 이동
                        row++;
                        if (row == n || answer[row, col] != 0) // 범위를 벗어나거나 이미 값이 채워진 경우
                        {
                            row--;
                            col++;
                            direction = 1; // 오른쪽으로 이동
                        }
                        break;
                    case 1: // 오른쪽로 이동
                        col++;
                        if (col == n || answer[row, col] != 0) // 범위를 벗어나거나 이미 값이 채워진 경우
                        {
                            row--;
                            col -= 2;
                            direction = 2; // 왼쪽대각선위로 이동
                        }
                        break;
                    case 2: // 왼쪽대각선위로 이동
                        col--;
                        row--;
                        if (answer[row, col] != 0) // 범위를 벗어나거나 이미 값이 채워진 경우
                        {
                            col++;
                            row += 2;
                            direction = 0; // 아래로 이동
                        }
                        break;
                }
            }

            int[] answerToOneDimension = GetOneDimension(answer);

            return answerToOneDimension;
        }

        private int GetLength(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            if (num == 1)
            {
                return 1;
            }

            return GetLength(num - 1) + num;
        }

        private int[] GetOneDimension(int[,] twoDimension)
        {
            int[] arr = new int[len];
            int idx = 0;
            for(int i = 0; i < twoDimension.GetLength(0); i++)
            {
                for(int j = 0; j < twoDimension.GetLength(1); j++)
                {
                    if (twoDimension[i, j] != 0)
                    {
                        arr[idx++] = twoDimension[i, j];
                    }
                }
            }

            return arr;
        }
    }
}
