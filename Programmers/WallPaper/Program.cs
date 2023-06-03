using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallPaper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] wallpaper = { ".#...", "..#..", "...#." };
            solution.solution(wallpaper);
        }
    }

    public class Solution
    {
        public int[] solution(string[] wallpaper)
        {
            int[] answer = new int[4];
            List<int> sharpListX = new List<int>();
            List<int> sharpListY = new List<int>();
            char[,] wallPaperCoord = new char[wallpaper.Length, wallpaper[0].Length];

            for(int i = 0; i < wallPaperCoord.GetLength(0); ++i)
            {
                for(int j = 0; j < wallPaperCoord.GetLength(1); ++j)
                {
                    wallPaperCoord[i, j] = wallpaper[i][j];
                    if (wallPaperCoord[i, j] == '#')
                    {
                        sharpListX.Add(i);
                        sharpListY.Add(j);
                    }
                }
            }

            answer[0] = sharpListX.Min();
            answer[1] = sharpListY.Min();
            answer[2] = sharpListX.Max() + 1;
            answer[3] = sharpListY.Max() + 1;


            return answer;
        }
    }
}
