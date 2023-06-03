using System.Collections.Generic;

namespace TableEditing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] commands = new string[] { "UPDATE 1 1 menu", "UPDATE 1 2 category", "UPDATE 2 1 bibimbap", "UPDATE 2 2 korean", "UPDATE 2 3 rice", "UPDATE 3 1 ramyeon", "UPDATE 3 2 korean", "UPDATE 3 3 noodle", "UPDATE 3 4 instant", "UPDATE 4 1 pasta", "UPDATE 4 2 italian", "UPDATE 4 3 noodle", "MERGE 1 2 1 3", "MERGE 1 3 1 4", "UPDATE korean hansik", "UPDATE 1 3 group", "UNMERGE 1 4", "PRINT 1 3", "PRINT 1 4" };
            solution.solution(commands);
        }
    }

    public class Solution
    {
        private int[] parent = new int[2501];
        private string[] value = new string[2501];

        //UNION-FIND 알고리즘
        private int Find(int a)
        {
            if (parent[a] == a)
                return a;
            else
                return parent[a] = Find(parent[a]);
        }

        private void Union(int a, int b)
        {
            a = Find(a);
            b = Find(b);
            if (a != b)
                parent[b] = a;
        }

        //좌표를 번호로 변환
        private int ConvertNum(int x, int y)
        {
            int result = 50 * (x - 1);
            return result + y;
        }

        public string[] solution(string[] commands)
        {
            //초기화
            for (int i = 1; i <= 2500; i++)
            {
                parent[i] = i;
                value[i] = "";
            }

            //명령어 실행
            List<string> result = new List<string>();
            for (int ind = 0; ind < commands.Length; ind++)
            {
                string line = commands[ind];
                string[] tokens = line.Split(' ');
                string command = tokens[0];

                if (command == "UPDATE")
                {
                    //UPDATE value1 value2
                    if (tokens.Length == 3)
                    {
                        string before = tokens[1];
                        string after = tokens[2];
                        for (int i = 1; i <= 2500; i++)
                        {
                            if (before == value[i])
                                value[i] = after;
                        }
                    }
                    //UPDATE x y value
                    else
                    {
                        int x = int.Parse(tokens[1]);
                        int y = int.Parse(tokens[2]);
                        string after = tokens[3];
                        int num = ConvertNum(x, y);
                        value[Find(num)] = after;
                    }
                }
                else if (command == "MERGE")
                {
                    int x1 = int.Parse(tokens[1]);
                    int y1 = int.Parse(tokens[2]);
                    int x2 = int.Parse(tokens[3]);
                    int y2 = int.Parse(tokens[4]);
                    int n1 = ConvertNum(x1, y1);
                    int n2 = ConvertNum(x2, y2);
                    int root1 = Find(n1);
                    int root2 = Find(n2);
                    //0. 같은 그룹이면 무시
                    if (root1 == root2) continue;
                    //1. 값을 가진쪽으로 병합
                    string rootString = value[root1].Trim().Length == 0 ? value[root2] : value[root1];
                    value[root1] = "";
                    value[root2] = "";
                    Union(root1, root2);
                    value[root1] = rootString;
                }
                else if (command == "UNMERGE")
                {
                    int x = int.Parse(tokens[1]);
                    int y = int.Parse(tokens[2]);
                    int num = ConvertNum(x, y);
                    int root = Find(num);
                    string rootString = value[root];
                    value[root] = "";
                    value[num] = rootString;
                    List<int> deleteList = new List<int>();
                    for (int i = 1; i <= 2500; i++)
                    {
                        if (Find(i) == root)
                            deleteList.Add(i);
                    }
                    foreach (int t in deleteList)
                        parent[t] = t;
                }
                else if (command == "PRINT")
                {
                    int x = int.Parse(tokens[1]);
                    int y = int.Parse(tokens[2]);
                    int num = ConvertNum(x, y);
                    int root = Find(num);
                    if (value[root].Trim().Length == 0)
                        result.Add("EMPTY");
                    else
                        result.Add(value[root]);
                }
            }
            return result.ToArray();
        }
    }

}