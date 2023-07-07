using System;
using System.Collections.Generic;

namespace DiscountEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] want = { "banana", "apple", "rice", "pork", "pot" };
            int[] number = { 3, 2, 2, 2, 1 };
            string[] discount = { "chicken", "apple", "apple", "banana", "rice", "apple", "pork", "banana", "pork", "rice", "pot", "banana", "apple", "banana" };
            Console.WriteLine(solution.solution(want, number, discount));
        }
    }

    public class Solution
    {
        public int solution(string[] want, int[] number, string[] discount)
        {
            int answer = 0;

            Dictionary<string, int> needs = new Dictionary<string, int>();

            for(int i = 0; i < number.Length; i++)
            {
                needs.Add(want[i], number[i]);
            }

            List<string> checkList = new List<string>();

            for(int i = 0; i < 10; i++)
            {
                checkList.Add(discount[i]);
            }

            for(int i = 0; i <= discount.Length - 10; i++)
            {
                if(i == 0)
                {
                    // 확인
                    if (Check(checkList, needs))
                    {
                        answer++;
                    }
                }
                else
                {
                    // 처음요소 제거후 맨뒤 요소를 추가
                    checkList.RemoveAt(0);
                    checkList.Add(discount[i + 10 - 1]);

                    // 확인
                    if (Check(checkList, needs))
                    {
                        answer++;
                    }
                }
            }

            return answer;
        }

        private bool Check(List<string> curList, Dictionary<string, int> needs)
        {
            Dictionary<string, int> checkDic = new Dictionary<string, int>(needs);

            foreach(string cur in curList) 
            {
                if (checkDic.ContainsKey(cur))
                {
                    checkDic[cur] -= 1;
                    if (checkDic[cur] == 0)
                    {
                        checkDic.Remove(cur);
                    }
                }
            }

            return checkDic.Count == 0 ? true : false;
        }
    }
}
