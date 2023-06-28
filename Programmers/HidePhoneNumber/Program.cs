using System;
using System.Text;

namespace HidePhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution("01033334444"));
        }
    }

    public class Solution
    {
        public string solution(string phone_number)
        {
            StringBuilder sb = new StringBuilder();
            int length = phone_number.Length;
            for(int i = 0; i < phone_number.Length - 4; i++)
            {
                sb.Append("*");
            }

            sb.Append(phone_number[length - 4]);
            sb.Append(phone_number[length - 3]);
            sb.Append(phone_number[length - 2]);
            sb.Append(phone_number[length - 1]);

            return sb.ToString();
        }
    }
}
