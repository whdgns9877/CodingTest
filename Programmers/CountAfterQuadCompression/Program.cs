using System;

namespace CountAfterQuadCompression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[,] arr = {
                { 1,1,1,1,1,1,1,1 },
                { 0,1,1,1,1,1,1,1 },
                { 0,0,0,0,1,1,1,1 },
                { 0,1,0,0,1,1,1,1 },
                { 0,0,0,0,0,0,1,1 },
                { 0,0,0,0,0,0,0,1 },
                { 0,0,0,0,1,0,0,1 },
                { 0,0,0,0,1,1,1,1 }
            };

            int[] result = solution.solution(arr);

            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        private int[,] arr;
        private int[] answer;

        public int[] solution(int[,] arr)
        {
            this.arr = arr;
            answer = new int[2];

            Compression(arr.GetLength(0), 0, 0);

            return answer;
        }

        private void Compression(int len, int startCol, int startRow)
        {
            if (len == 1)
            {
                // 현재 영역의 값이 0이면 answer[0] 카운트를 증가시키고
                // 값이 1이면 answer[1] 카운트를 증가시킨다
                if (arr[startRow, startCol] == 0)
                    answer[0]++;
                else
                    answer[1]++;
                return;
            }

            // 현재 영역의 모든 요소가 동일한지 확인한다
            int firstElement = arr[startRow, startCol];
            bool isAllElementsEqual = true;
            for (int i = startRow; i < startRow + len; i++)
            {
                for (int j = startCol; j < startCol + len; j++)
                {
                    if (arr[i, j] != firstElement)
                    {
                        isAllElementsEqual = false;
                        break;
                    }
                }
                if (!isAllElementsEqual)
                    break;
            }

            if (isAllElementsEqual)
            {
                // 현재 영역의 값이 0이면 answer[0] 카운트를 증가시키고
                // 값이 1이면 answer[1] 카운트를 증가시킨다
                if (firstElement == 0)
                    answer[0]++;
                else
                    answer[1]++;
            }
            else
            {
                // 영역을 4개로 분할하여 재귀적으로 압축한다
                int halfLen = len / 2;
                Compression(halfLen, startCol, startRow); // 왼쪽 위
                Compression(halfLen, startCol + halfLen, startRow); // 오른쪽 위
                Compression(halfLen, startCol, startRow + halfLen); // 왼쪽 아래
                Compression(halfLen, startCol + halfLen, startRow + halfLen); // 오른쪽 아래
            }
        }
    }
}
