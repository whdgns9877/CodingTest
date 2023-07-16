using System;
using System.Collections.Generic;

namespace CourierBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] order = { 5, 4, 3, 2, 1 };
            Console.WriteLine(solution.solution(order));
        }
    }

    public class Solution
    {
        public int solution(int[] order) // 택배 기사가 원하는 순서
        {
            int orderIndex = 0; // 택배 기사가 원하는 순서의 배열 인덱스
            Stack<int> tempBelt = new Stack<int>(); // 보조 벨트

            for (int i = 0; i < order.Length; ++i)
            {
                int box = i + 1; // 메인 벨트에서 나오는 박스에 써진 숫자
                if (box == order[orderIndex])
                {
                    ++orderIndex;
                }
                else
                {
                    tempBelt.Push(box);
                }

                while (tempBelt.Count > 0 && tempBelt.Peek() == order[orderIndex])
                {
                    tempBelt.Pop();
                    ++orderIndex;
                }
            }

            return orderIndex;
        }
    }
}
