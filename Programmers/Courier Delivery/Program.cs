using System;

namespace Courier_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int cap = 4;
            int n = 5;
            int[] deliveries = new int[5] { 1, 0, 3, 1, 2 };
            int[] pickups = new int[5] { 0, 3, 0, 4, 0 };
            Console.WriteLine(solution.solution(cap, n, deliveries, pickups));
        }
    }

    public class Solution
    {
        public long solution(int cap, int n, int[] deliveries, int[] pickups)
        {
            // 마지막 집 먼저 처리해야하므로 두 배열을 뒤집는다
            Array.Reverse(deliveries);
            Array.Reverse(pickups);

            long answer = 0;
            int deliNum = 0;
            int pickUpNum = 0;

            // 집 수만큼 반복
            for (int i = 0; i < n; i++)
            {
                // 배달해야할 수량과 수거할 수량을 파악
                deliNum += deliveries[i];
                pickUpNum += pickups[i];

                // 용량을 꽉채웠다 가정하고 배달해야할 수량과
                // 수거해야할 수량을 빼고 이 수치가 음수가 되었다는건 다 처리했다는 것이므로
                // while문 종료
                while (deliNum > 0 || pickUpNum > 0)
                {
                    deliNum -= cap;
                    pickUpNum -= cap;
                    // 방문을 했다면 다시 돌아가야 하므로 * 2
                    answer += (n - i) * 2;
                }
            }

            return answer;
        }
    }
}
