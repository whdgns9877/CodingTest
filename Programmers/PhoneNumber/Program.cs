namespace PhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string phoneNum = "01033334444";
            solution.solution(phoneNum);
        }
    }

    public class Solution
    {
        public string solution(string phone_number)
        {
            string answer = new string('*', phone_number.Length - 4) + phone_number.Substring(phone_number.Length - 4);
            return answer;
        }
    }
}
