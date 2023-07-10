using System;
using System.Linq;
using System.Text;

namespace SkillTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string skill = "CBD";
            string[] skill_trees = { "BACDE", "CBADF", "AECB", "BDA" };
            Console.WriteLine(solution.solution(skill, skill_trees));
        }
    }

    public class Solution
    {
        public int solution(string skill, string[] skill_trees)
        {
            int answer = 0;

            for (int i = 0; i < skill_trees.Length; i++)
            {
                string skill_tree = skill_trees[i];
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < skill_tree.Length; j++)
                {
                    if (skill.Contains(skill_tree[j]))
                    {
                        sb.Append(skill_tree[j]);
                    }
                }

                for (int j = skill.Length; j > -1; j--)
                {
                    string s = skill.Substring(0, j);
                    if (s.Equals(sb.ToString()))
                    {
                        answer++;
                        break;
                    }
                }

            }
            return answer;
        }
    }
}
