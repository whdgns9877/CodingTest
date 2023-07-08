using System;

namespace TargetNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] numbers = { 4, 1, 2, 1 };
            Console.WriteLine(solution.solution(numbers, 4));
        }
    }

    public class Solution
    {
        public int solution(int[] numbers, int target)
        {
            int current = numbers[0];
            int answer = 0;
            // 첫번째 인덱스를 + 상태로 DFS 시작
            answer += DFS(current, 1, numbers, target);
            // 첫번째 인덱스를 - 상태로 DFS 시작
            answer += DFS(-current, 1, numbers, target);
            return answer;
        }

        public int DFS(int prev, int index, int[] numbers, int target)
        {
            // 모든 인덱스를 확인한 상태이고
            if (index >= numbers.Length)
            {
                // 결과가 target과 같으면 1 리턴
                if (target == prev)
                {
                    return 1;
                }
                // 같이 않다면 0 리턴
                return 0;
            }

            // 지금까지 더하거나 뺀 수에서 다시 더하거나
            int cur1 = prev + numbers[index];
            // 뺀 후에
            int cur2 = prev - numbers[index];

            int ans = 0;

            // 해당 인덱스에서부터 + 상태로 DFS 시작
            ans += DFS(cur1, index + 1, numbers, target);
            // 해당 인덱스에서부터 - 상태로 DFS 시작
            ans += DFS(cur2, index + 1, numbers, target);

            return ans;

        }
    }
}
