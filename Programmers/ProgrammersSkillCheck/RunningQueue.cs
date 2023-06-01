using System.Collections.Generic;

namespace ProgrammersSkillCheck
{
    internal class RunningQueue
    {
        public int solution(int[] priorities, int location)
        {
            int answer = 0;
            Queue<int> queue = new Queue<int>(priorities); // 실행 대기 큐 생성
            int target = location; // 찾고자 하는 프로세스 위치

            while (true)
            {
                int current = queue.Dequeue(); // 현재 프로세스를 큐에서 꺼냄
                bool isMaxPriority = true; // 현재 프로세스가 가장 높은 우선순위인지 여부

                foreach (int priority in queue)
                {
                    if (priority > current)
                    {
                        // 현재 프로세스보다 높은 우선순위가 있는 경우
                        isMaxPriority = false;
                        break;
                    }
                }

                if (isMaxPriority)
                {
                    // 현재 프로세스가 가장 높은 우선순위인 경우
                    answer++;

                    if (target == 0)
                    {
                        // 찾고자 하는 프로세스가 실행되는 경우 종료
                        break;
                    }
                }
                else
                {
                    // 현재 프로세스가 가장 높은 우선순위가 아닌 경우
                    queue.Enqueue(current);
                }

                // 찾고자 하는 프로세스의 위치 갱신
                target = (target - 1 + queue.Count) % queue.Count;
            }

            return answer;
        }
    }
}
