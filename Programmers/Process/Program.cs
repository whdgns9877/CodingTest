using System;
using System.Collections.Generic;
using System.Linq;

namespace Process
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] priorities = { 1, 1, 9, 1, 1, 1 };
            Console.WriteLine(solution.solution(priorities, 0));
        }
    }

    public class Solution
    {
        public int solution(int[] priorities, int location)
        {
            int answer = 0;

            Queue<int> runningQueue = new Queue<int>(priorities);

            while (true)
            {
                int curProcess = runningQueue.Dequeue();
                if(runningQueue.Count == 0)
                {
                    answer++;
                    break;
                }
                if (runningQueue.Max() <= curProcess)
                {
                    answer++;
                    if(location == 0)
                    {
                        break;
                    }
                }
                else
                {
                    runningQueue.Enqueue(curProcess);
                }
                location = location - 1 < 0 ? runningQueue.Count - 1 : location - 1;
            }

            return answer;
        }
    }
}
