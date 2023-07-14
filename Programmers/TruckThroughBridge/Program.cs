using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckThroughBridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] truck_weights = { 7, 4, 5, 6 };
            Console.WriteLine(solution.solution(2, 10, truck_weights));
        }
    }

    public class Solution
    {
        public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int time = 0;
            Queue<int> trucks = new Queue<int>(truck_weights);
            int[] availableTruck = Enumerable.Repeat(-1, truck_weights.Length).ToArray();
            List<int> onBridgeTruckList = new List<int>();
            int idx = 0;

            // 모든 트럭이 다 지나가고 마지막 트럭까지 지나가면 종료
            while (trucks.Count > 0 || onBridgeTruckList.Count > 0)
            {
                time++; // 시간 증가

                // 다리 위의 트럭들이 1칸씩 전진
                if (onBridgeTruckList.Count > 0)
                {
                    for (int i = 0; i < onBridgeTruckList.Count; i++)
                    {
                        availableTruck[onBridgeTruckList[i]]--; // 다리에 올라간 트럭의 남은 이동 거리 감소

                        // 트럭이 bridge_length만큼 전진했다면 도착
                        if (availableTruck[onBridgeTruckList[i]] == 0)
                        {
                            weight += truck_weights[onBridgeTruckList[i]]; // 도착한 트럭의 무게를 다리 위의 총 무게에서 빼줌
                            onBridgeTruckList.RemoveAt(i); // 도착한 트럭을 다리 위에서 제거
                            i--; // 다음 인덱스 처리를 위해 인덱스 감소
                        }
                    }
                }

                // 다음 트럭이 다리에 올라갈 수 있는 경우
                if (trucks.Count > 0 && weight >= truck_weights[idx])
                {
                    int truck = trucks.Dequeue(); // 다음 트럭을 큐에서 가져옴
                    weight -= truck; // 다리 위의 총 무게에 트럭의 무게를 더해줌
                    onBridgeTruckList.Add(idx); // 다리 위 트럭 리스트에 인덱스 추가
                    availableTruck[idx] = bridge_length; // 다리 위 트럭의 남은 이동 거리 설정
                    idx++; // 트럭 인덱스 증가
                }
            }

            return time;
        }
    }
}
