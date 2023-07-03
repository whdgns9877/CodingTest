using System;

namespace NCountLCM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] arr = { 3, 2, 1 };
            Console.WriteLine(solution.solution(arr));
        }
    }

    public class Solution
    {
        public int solution(int[] arr)
        {
            Array.Sort(arr);
            int checkNum = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                checkNum = GetLCM(checkNum, arr[i + 1]);
            }

            return checkNum;
        }

        // 최대공약수 구하기
        private int GetLCM(int num1, int num2)
        {
            int gcd = GetGCD(num1, num2);
            return (num1 * num2) / gcd;
        }

        // 최소공배수 구하기
        private int GetGCD(int num1, int num2)
        {
            if (num2 == 0)
                return num1;

            return GetGCD(num2, num1 % num2);
        }
    }
}
