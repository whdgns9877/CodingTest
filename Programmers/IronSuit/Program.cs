namespace IronSuit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(6);
        }
    }

    class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            // 점프, 순간이동
            // 점프는 이동할수있는데 answer양이 증가한다
            // 순간이동은 지금까지 온거리 x2 할수있다

            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n -= 1;
                    answer += 1;
                }
            }

            return answer;
        }
    }
}
