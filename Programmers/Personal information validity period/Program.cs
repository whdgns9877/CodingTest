using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_information_validity_period
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        // 파기해야할 약관 구하기
        public int[] solution(string today, string[] terms, string[] privacies)
        {
            int[] tempArr = new int[privacies.Length];
            int Count = 0;

            // 입력으로 주어진 오늘의 년,월,일을 구한다
            int todayYear = int.Parse(today.Split('.')[0]);
            int todayMonth = int.Parse(today.Split('.')[1]);
            int todayDay = int.Parse(today.Split('.')[2]);

            // 약관이 무엇인지 구한다
            for (int i = 0; i < privacies.Length; ++i)
            {
                // 해당 약관종류에 따라 구해놓은 termsToInt 배열에 맞춰
                // 개인정보 수집일자에서 유효기간만큼 더한다
                // 한달 기준 28일 이므로 더해야 하는 날짜에 기간 X 28
                int myAddDay = 0;
                string[] privacy = privacies[i].Split('.', ' ');
                int year = int.Parse(privacy[0]);
                int month = int.Parse(privacy[1]);
                int day = int.Parse(privacy[2]);
                string term = privacy[3];

                for (int j = 0; j < terms.Length; ++j)
                {
                    if (term == terms[j].Split(' ')[0])
                    {
                        myAddDay = int.Parse(terms[j].Split(' ')[1]) * 28;
                        break;
                    }
                }

                int endYear = year;
                int endMonth = month;
                int endDay = day;

                while (myAddDay > 1)
                {
                    if (endDay == 28)
                    {
                        endDay = 1;
                        endMonth++;
                        if (endMonth == 13)
                        {
                            endMonth = 1;
                            endYear++;
                        }
                    }
                    else
                    {
                        endDay++;
                    }
                    myAddDay--;
                }

                if (endYear < todayYear) { tempArr[i] = i + 1; Count++; continue; }
                else if (endYear == todayYear)
                {
                    if (endMonth < todayMonth) { tempArr[i] = i + 1; Count++; continue; }
                    else if (endMonth == todayMonth)
                    {
                        if (endDay < todayDay) { tempArr[i] = i + 1; Count++; continue; }
                    }
                }

                tempArr[i] = 0;
            }

            int[] answer = new int[Count];

            int idx = 0;
            for (int i = 0; i < tempArr.Length; ++i)
            {
                if (tempArr[i] != 0)
                {
                    answer[idx] = tempArr[i];
                    idx++;
                    continue;
                }
            }

            return answer;
        }
    }
}
