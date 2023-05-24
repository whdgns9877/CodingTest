namespace Load_On_Truck
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[] solution(int[] truck, int[] w)
        {
            int[] answer = new int[w.Length];

            for (int i = 0; i < w.Length; i++)
            {
                int weight = w[i];
                int truckIndex = -1;

                for (int j = 0; j < truck.Length; j++)
                {
                    if (truck[j] >= weight)
                    {
                        truckIndex = j;
                        break;
                    }
                }

                if (truckIndex == -1)
                {
                    answer[i] = -1;
                }
                else
                {
                    answer[i] = truckIndex + 1;
                    truck[truckIndex] -= weight;
                }
            }

            return answer;
        }
    }
}
