using System;

namespace EmoticonSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[,] users = new int[,] { { 40, 10000 }, { 25, 10000 } };
            int[] emoticons = new int[] { 7000, 9000 };
            solution.solution(users, emoticons);
        }
    }

    public class Solution
    {
        public int[] solution(int[,] users, int[] emoticons)
        {
            int n = users.GetLength(0); // 사용자 수
            int m = emoticons.Length; // 이모티콘 수

            int[] answer = new int[2]; // 결과 배열 [이모티콘 플러스 서비스 가입 수, 이모티콘 판매액]
            int maxJoin = 0; // 최대 이모티콘 플러스 서비스 가입 수
            int maxRevenue = 0; // 최대 이모티콘 판매액

            // 각 이모티콘에 대해 할인율을 조합하여 가격을 계산하고, 사용자별로 조건에 맞게 처리
            for (int i = 0; i < (1 << m); i++)
            {
                int[] price = new int[m]; // 각 이모티콘의 가격
                int joinCount = 0; // 이모티콘 플러스 서비스 가입 수
                int revenue = 0; // 이모티콘 판매액

                // 할인율 조합에 따른 가격 계산
                for (int j = 0; j < m; j++)
                {
                    int discount = (i & (1 << j)) != 0 ? users[j, 0] : 0; // 할인율
                    price[j] = emoticons[j] * (100 - discount) / 100; // 할인된 가격 계산
                }

                // 사용자별로 처리
                for (int j = 0; j < n; j++)
                {
                    int ratio = users[j, 0]; // 사용자의 비율
                    int budget = users[j, 1]; // 사용자의 예산
                    int maxPrice = 0; // 최대 구매 가능 가격

                    // 자신의 비율 이상 할인되는 이모티콘을 모두 구매
                    for (int k = 0; k < m; k++)
                    {
                        if (price[k] * 100 >= emoticons[k] * ratio)
                        {
                            joinCount++;
                            revenue += price[k];
                            budget -= price[k];
                        }
                        else
                        {
                            maxPrice = Math.Max(maxPrice, price[k]);
                        }
                    }

                    // 구매한 이모티콘의 가격 합이 예산보다 큰 경우, 이모티콘 구매 취소하고 이모티콘 플러스 서비스 가입
                    if (budget < 0)
                    {
                        joinCount--;
                        revenue -= maxPrice;
                    }
                }

                // 최대 이모티콘 플러스 서비스 가입 수와 이모티콘 판매액 갱신
                if (joinCount > maxJoin || (joinCount == maxJoin && revenue > maxRevenue))
                {
                    maxJoin = joinCount;
                    maxRevenue = revenue;
                }
            }

            answer[0] = maxJoin;
            answer[1] = maxRevenue;

            return answer;
        }
    }

}
