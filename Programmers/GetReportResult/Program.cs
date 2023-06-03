using System.Collections.Generic;
using System.Linq;

namespace GetReportResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // 기존 코드 -> 정답은 맞지만 시간초과가 발생하는경우가 생겨서 최적화
    //public class Solution
    //{
    //    public int[] solution(string[] id_list, string[] report, int k)
    //    {
    //        int[] answer = new int[id_list.Length];
    //        string[] distReport = report.Distinct().ToArray();
    //        int[] reportedCnt = new int[id_list.Length];

    //        for (int i = 0; i < id_list.Length; ++i)
    //        {
    //            int count = 0;
    //            for (int j = 0; j < distReport.Length; ++j)
    //            {
    //                if (distReport[j].Split(' ')[1] == id_list[i])
    //                {
    //                    count++;
    //                }
    //            }

    //            reportedCnt[i] = count;
    //        }

    //        List<string> tobestopped = new List<string>();

    //        for (int i = 0; i < reportedCnt.Length; ++i)
    //        {
    //            if (reportedCnt[i] >= k)
    //            {
    //                tobestopped.Add(id_list[i]);
    //            }
    //        }

    //        for (int i = 0; i < id_list.Length; i++)
    //        {
    //            int receiveReportedCnt = 0;
    //            for (int j = 0; j < distReport.Length; ++j)
    //            {
    //                if (distReport[j].Split(' ')[0] == id_list[i])
    //                {

    //                    if (tobestopped.Contains(distReport[j].Split(' ')[1]))
    //                    {
    //                        receiveReportedCnt++;
    //                    }

    //                }
    //                answer[i] = receiveReportedCnt;
    //            }
    //        }

    //        return answer;
    //    }
    //}

    public class Solution
    {
        public int[] solution(string[] id_list, string[] report, int k)
        {
            int[] answer = new int[id_list.Length];
            Dictionary<string, int> reportedCnt = new Dictionary<string, int>();
            Dictionary<string, List<string>> reportMap = new Dictionary<string, List<string>>();

            foreach (string id in id_list)
            {
                reportedCnt[id] = 0;
                reportMap[id] = new List<string>();
            }

            foreach (string rep in report.Distinct())
            {
                string[] splitted = rep.Split(' ');
                string reporter = splitted[0];
                string target = splitted[1];

                if (!reportMap[target].Contains(reporter))
                {
                    reportedCnt[target]++;
                    reportMap[target].Add(reporter);
                }
            }

            List<string> toBeStopped = new List<string>();

            foreach (var pair in reportedCnt)
            {
                if (pair.Value >= k)
                {
                    toBeStopped.Add(pair.Key);
                }
            }

            foreach (string rep in report.Distinct())
            {
                string[] splitted = rep.Split(' ');
                string reporter = splitted[0];
                string target = splitted[1];

                if (toBeStopped.Contains(target))
                {
                    answer[id_list.ToList().IndexOf(reporter)]++;
                }
            }

            return answer;
        }
    }
}
