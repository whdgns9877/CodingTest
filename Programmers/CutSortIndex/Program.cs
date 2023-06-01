using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutSortIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] array = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
            solution.solution(array, commands);
        }
    }

    public class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];
            for(int i = 0; i < commands.GetLength(0); ++i)
            {
                int startIndex = commands[i, 0];  // 자를 부분의 시작 인덱스
                int endIndex = commands[i, 1];    // 자를 부분의 마지막 인덱스

                int length = endIndex - startIndex + 1;  // 자를 부분의 길이

                int[] slicedArray = new int[length];  // 자른 결과를 저장할 새로운 배열 생성

                Array.Copy(array, startIndex - 1, slicedArray, 0, length);  // 배열 자르기
                Array.Sort(slicedArray); // 배열 정렬
                answer[i] = slicedArray[commands[i,2] - 1];
            }
            return answer;
        }
    }
}
