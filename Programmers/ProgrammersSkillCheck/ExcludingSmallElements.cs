using System.Linq;

namespace ProgrammersSkillCheck
{
    internal class ExcludingSmallElements
    {
        public int[] solution(int[] arr)
        {
            int[] answer = new int[] { };

            if (arr.Length <= 1) answer = new int[1] { -1 };
            else
            {
                int min = arr.Min();
                int[] newArray = arr.Where(x => x != min).ToArray();
                answer = newArray;
            }

            return answer;
        }
    }
}
