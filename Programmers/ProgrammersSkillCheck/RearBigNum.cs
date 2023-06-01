using System.Linq;

namespace ProgrammersSkillCheck
{
    internal class RearBigNum
    {
        public int[] solution(int[] numbers)
        {
            int[] answer = new int[numbers.Length];

            for(int i = 0; i < numbers.Length; ++i)
            {
                int[] checkArr = numbers.Skip(i + 1).ToArray();
            }

            return answer;
        }

    }
}
