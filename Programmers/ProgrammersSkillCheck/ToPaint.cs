using System.Linq;

namespace ProgrammersSkillCheck
{
    internal class ToPaint
    {
        public int solution(int n, int m, int[] section)
        {
            int answer = 0;
            int max = section.Max();
            int min = section.Min();

            while (min <= max)
            {
                int mid = (max + min) / 2; // 현재 구역을 가운데 구역으로 설정
                int paintCount = 0; // 페인트칠 횟수

                int prevSection = 0; // 이전에 페인트를 다시 칠한 구역의 번호
                foreach (int currentSection in section)
                {
                    int distance = currentSection - prevSection - 1; // 현재 구역과 이전 구역 사이의 거리 계산
                    paintCount += (distance + m - 1) / m; // 거리를 롤러의 길이로 나눈 뒤 올림하여 페인트칠 횟수에 더함
                    prevSection = currentSection; // 현재 구역을 이전 구역으로 설정
                }

                // 마지막 구역부터 끝까지의 거리를 계산하여 페인트칠 횟수에 더함
                int lastDistance = n - section[section.Length - 1];
                paintCount += (lastDistance + m - 1) / m;

                if (paintCount <= mid)
                {
                    answer = mid; // 현재 구역 수를 정답으로 갱신
                    max = mid - 1; // 최댓값을 갱신하여 다음 이진 탐색 범위를 설정
                }
                else
                {
                    min = mid + 1; // 최솟값을 갱신하여 다음 이진 탐색 범위를 설정
                }
            }

            return answer;
        }
    }
}
