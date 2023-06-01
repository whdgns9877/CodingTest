namespace WalkInThePark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] park = { "OSO", "OOO", "OXO", "OOO" };
            string[] routes = { "E 2", "S 3", "W 1" };
            solution.solution(park, routes);
        }
    }

    public class Solution
    {
        public int[] solution(string[] park, string[] routes)
        {
            int rowCount = park.Length;               // 배열의 행 수
            int colCount = park[0].Length;            // 배열의 열 수 (가정: 모든 행의 길이가 동일)

            char[,] map = new char[rowCount, colCount];   // 2차원 char 배열 생성

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    map[i, j] = park[i][j];    // 문자열의 각 문자를 2차원 배열에 할당
                }
            }

            // 시작 지점 찾기
            int startRow = -1;
            int startCol = -1;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (map[i, j] == 'S')
                    {
                        startRow = i;
                        startCol = j;
                        break;
                    }
                }
                if (startRow != -1 && startCol != -1)
                {
                    break;
                }
            }

            // 이동 방향 및 거리에 따라 이동하기
            int currentRow = startRow;
            int currentCol = startCol;
            foreach (string route in routes)
            {
                string[] split = route.Split(' ');
                char direction = split[0][0];
                int distance = int.Parse(split[1]);

                // 이동 가능한 범위인지 확인
                bool isValidMove = true;
                switch (direction)
                {
                    case 'E':  // 동쪽 이동
                        if (currentCol + distance >= colCount)
                        {
                            isValidMove = false;
                        }
                        else
                        {
                            for (int i = 1; i <= distance; i++)
                            {
                                if (map[currentRow, currentCol + i] == 'X')
                                {
                                    isValidMove = false;
                                    break;
                                }
                            }
                        }
                        if (isValidMove)
                        {
                            currentCol += distance;
                        }
                        break;

                    case 'S':  // 남쪽 이동
                        if (currentRow + distance >= rowCount)
                        {
                            isValidMove = false;
                        }
                        else
                        {
                            for (int i = 1; i <= distance; i++)
                            {
                                if (map[currentRow + i, currentCol] == 'X')
                                {
                                    isValidMove = false;
                                    break;
                                }
                            }
                        }
                        if (isValidMove)
                        {
                            currentRow += distance;
                        }
                        break;

                    case 'W':  // 서쪽 이동
                        if (currentCol - distance < 0)
                        {
                            isValidMove = false;
                        }
                        else
                        {
                            for (int i = 1; i <= distance; i++)
                            {
                                if (map[currentRow, currentCol - i] == 'X')
                                {
                                    isValidMove = false;
                                    break;
                                }
                            }
                        }
                        if (isValidMove)
                        {
                            currentCol -= distance;
                        }
                        break;

                    case 'N':  // 북쪽 이동
                        if (currentRow - distance < 0)
                        {
                            isValidMove = false;
                        }
                        else
                        {
                            for (int i = 1; i <= distance; i++)
                            {
                                if (map[currentRow - i, currentCol] == 'X')
                                {
                                    isValidMove = false;
                                    break;
                                }
                            }
                        }
                        if (isValidMove)
                        {
                            currentRow -= distance;
                        }
                        break;
                }

                if (!isValidMove)
                {
                    // 유효한 이동이 아니면 해당 명령은 무시하고 다음 명령 수행
                    continue;
                }
            }

            int[] answer = new int[] { currentRow, currentCol };
            return answer;
        }

    }
}
