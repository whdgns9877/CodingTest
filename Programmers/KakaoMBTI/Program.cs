using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KakaoMBTI
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public class Solution
        {
            public string solution(string[] survey, int[] choices)
            {
                int AScore = 0;
                int NScore = 0;
                int CScore = 0;
                int FScore = 0;
                int RScore = 0;
                int TScore = 0;
                int JScore = 0;
                int MScore = 0;
                string answer = "";

                for (int i = 0; i < survey.Length; i++)
                {
                    if (survey[i][0] == 'A')

                    {

                        switch (choices[i])

                        {
                            case 1:
                                AScore += 3;
                                break;

                            case 2:
                                AScore += 2;
                                break;

                            case 3:
                                AScore += 1;
                                break;

                            case 5:
                                NScore += 1;
                                break;


                            case 6:
                                NScore += 2;
                                break;


                            case 7:
                                NScore += 3;
                                break;
                        }
                    }
                    if (survey[i][0] == 'N')
                    {
                        switch (choices[i])
                        {
                            case 1:
                                NScore += 3;
                                break;

                            case 2:
                                NScore += 2;
                                break;

                            case 3:
                                NScore += 1;
                                break;

                            case 5:
                                AScore += 1;
                                break;

                            case 6:
                                AScore += 2;
                                break;

                            case 7:
                                AScore += 3;
                                break;
                        }
                    }

                    if (survey[i][0] == 'R')
                    {
                        switch (choices[i])
                        {
                            case 1:
                                RScore += 3;
                                break;

                            case 2:
                                RScore += 2;
                                break;

                            case 3:
                                RScore += 1;
                                break;

                            case 5:
                                TScore += 1;
                                break;

                            case 6:
                                TScore += 2;
                                break;

                            case 7:
                                TScore += 3;
                                break;
                        }
                    }

                    if (survey[i][0] == 'T')
                    {
                        switch (choices[i])
                        {
                            case 1:
                                TScore += 3;
                                break;

                            case 2:
                                TScore += 2;
                                break;

                            case 3:
                                TScore += 1;
                                break;

                            case 5:
                                RScore += 1;
                                break;

                            case 6:
                                RScore += 2;
                                break;

                            case 7:
                                RScore += 3;
                                break;
                        }
                    }

                    if (survey[i][0] == 'F')
                    {
                        switch (choices[i])
                        {
                            case 1:
                                FScore += 3;
                                break;

                            case 2:
                                FScore += 2;
                                break;

                            case 3:
                                FScore += 1;
                                break;

                            case 5:
                                CScore += 1;
                                break;

                            case 6:
                                CScore += 2;
                                break;

                            case 7:
                                CScore += 3;
                                break;
                        }
                    }

                    if (survey[i][0] == 'C')
                    {
                        switch (choices[i])
                        {
                            case 1:
                                CScore += 3;
                                break;

                            case 2:
                                CScore += 2;
                                break;

                            case 3:
                                CScore += 1;
                                break;

                            case 5:
                                FScore += 1;
                                break;

                            case 6:
                                FScore += 2;
                                break;

                            case 7:
                                FScore += 3;
                                break;
                        }
                    }

                    if (survey[i][0] == 'M')
                    {
                        switch (choices[i])
                        {
                            case 1:
                                MScore += 3;
                                break;

                            case 2:
                                MScore += 2;
                                break;

                            case 3:
                                MScore += 1;
                                break;

                            case 5:
                                JScore += 1;
                                break;

                            case 6:
                                JScore += 2;
                                break;

                            case 7:
                                JScore += 3;
                                break;
                        }
                    }
                    if (survey[i][0] == 'J')
                    {
                        switch (choices[i])
                        {
                            case 1:
                                JScore += 3;
                                break;

                            case 2:
                                JScore += 2;
                                break;

                            case 3:
                                JScore += 1;
                                break;

                            case 5:
                                MScore += 1;
                                break;

                            case 6:
                                MScore += 2;
                                break;

                            case 7:
                                MScore += 3;
                                break;
                        }
                    }

                }
                if (RScore >= TScore)
                {
                    answer += "R";
                }
                else
                {
                    answer += "T";
                }

                if (CScore >= FScore)
                {
                    answer += "C";
                }
                else
                {
                    answer += "F";
                }

                if (JScore >= MScore)
                {
                    answer += "J";
                }
                else
                {
                    answer += "M";
                }

                if (AScore >= NScore)
                {
                    answer += "A";
                }
                else
                {
                    answer += "N";
                }
                return answer;
            }
        }
    }
}
