using System;

public class Solution
{
    private const char P = 'P';
    private const char O = 'O';
    private const int WRONG = 0;

    public int[] solution(string[,] places)
    {
        int[] answer = new int[5];

        for (int i = 0; i < 5; i++)
        {
            string[] tempArray = new string[5];

            tempArray[0] = places[i, 0];
            tempArray[1] = places[i, 1];
            tempArray[2] = places[i, 2];
            tempArray[3] = places[i, 3];
            tempArray[4] = places[i, 4];

            answer[i] = KeepDistanceWell(tempArray);
        }

        return answer;
    }

    public int KeepDistanceWell(string[] place)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (place[i][j] == P)
                {
                    // 위쪽 확인
                    if (i - 1 >= 0)
                    {
                        if (place[i - 1][j] == P) { return WRONG; }
                        if (place[i - 1][j] == O)
                        {
                            if (i - 2 >= 0 && place[i - 2][j] == P) { return WRONG; }
                            if (j + 1 <= 4 && place[i - 1][j + 1] == P) { return WRONG; }
                        }
                    }

                    // 오른쪽 확인
                    if (j + 1 <= 4)
                    {
                        if (place[i][j + 1] == P) { return WRONG; }
                        if (place[i][j + 1] == O)
                        {
                            if (j + 2 <= 4 && place[i][j + 2] == P) { return WRONG; }
                            if (i + 1 <= 4 && place[i + 1][j + 1] == P) { return WRONG; }
                            if (i - 1 >= 0 && place[i - 1][j + 1] == P) { return WRONG; }
                        }
                    }

                    // 아래쪽 확인
                    if (i + 1 <= 4)
                    {
                        if (place[i + 1][j] == P) { return WRONG; }
                        if (place[i + 1][j] == O)
                        {
                            if (i + 2 <= 4 && place[i + 2][j] == P) { return WRONG; }
                            if (j + 1 <= 4 && place[i + 1][j + 1] == P) { return WRONG; }
                        }
                    }

                    // 대각선 상단 확인
                    if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        if (place[i - 1][j - 1] == P)
                        {
                            if (place[i - 1][j] != 'X' || place[i][j - 1] != 'X')
                            {
                                return WRONG;
                            }
                        }
                    }

                    // 대각선 하단 확인
                    if (i + 1 <= 4 && j - 1 >= 0)
                    {
                        if (place[i + 1][j - 1] == P)
                        {
                            if (place[i + 1][j] != 'X' || place[i][j - 1] != 'X')
                            {
                                return WRONG;
                            }
                        }
                    }
                }
            }
        }

        return 1;
    }
}
