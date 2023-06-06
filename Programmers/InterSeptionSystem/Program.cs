using System;

internal class Program
{
    static void Main(string[] args)
    {
        int[,] targets = new int[,] {
            { 4, 5 },
            { 4, 8 },
            { 10, 14 },
            { 11, 13 },
            { 5, 12 },
            { 3, 7 },
            { 1, 4 }
        };

        Solution solution = new Solution();
        int result = solution.solution(targets);
        Console.WriteLine(result);
    }
}


public class Solution
{
    private int answer;

    public int solution(int[,] targets)
    {
        int n = targets.GetLength(0); // 배열의 행의 개수
        answer = 0;

        // 미사일 범위에 따라 오름차순으로 정렬
        MergeSort(targets, 0, n - 1);

        int last = -1;
        for (int i = 0; i < n; i++)
        {
            int start = targets[i, 0];
            int end = targets[i, 1];

            if (last == -1)
            {
                answer++;
                last = end - 1;
                continue;
            }

            if (last >= start && last <= end) continue;

            answer++;
            last = end - 1;
        }

        return answer;
    }

    private void MergeSort(int[,] arr, int low, int high)
    {
        if (low < high)
        {
            int mid = (low + high) / 2;
            MergeSort(arr, low, mid);
            MergeSort(arr, mid + 1, high);
            Merge(arr, low, mid, high);
        }
    }

    private void Merge(int[,] arr, int low, int mid, int high)
    {
        int leftSize = mid - low + 1;
        int rightSize = high - mid;

        int[,] leftArr = new int[leftSize, 2];
        int[,] rightArr = new int[rightSize, 2];

        for (int i = 0; i < leftSize; i++)
        {
            leftArr[i, 0] = arr[low + i, 0];
            leftArr[i, 1] = arr[low + i, 1];
        }

        for (int j = 0; j < rightSize; j++)
        {
            rightArr[j, 0] = arr[mid + 1 + j, 0];
            rightArr[j, 1] = arr[mid + 1 + j, 1];
        }

        int leftIndex = 0;
        int rightIndex = 0;
        int mergedIndex = low;

        while (leftIndex < leftSize && rightIndex < rightSize)
        {
            if (leftArr[leftIndex, 1] <= rightArr[rightIndex, 1])
            {
                arr[mergedIndex, 0] = leftArr[leftIndex, 0];
                arr[mergedIndex, 1] = leftArr[leftIndex, 1];
                leftIndex++;
            }
            else
            {
                arr[mergedIndex, 0] = rightArr[rightIndex, 0];
                arr[mergedIndex, 1] = rightArr[rightIndex, 1];
                rightIndex++;
            }
            mergedIndex++;
        }

        while (leftIndex < leftSize)
        {
            arr[mergedIndex, 0] = leftArr[leftIndex, 0];
            arr[mergedIndex, 1] = leftArr[leftIndex, 1];
            leftIndex++;
            mergedIndex++;
        }

        while (rightIndex < rightSize)
        {
            arr[mergedIndex, 0] = rightArr[rightIndex, 0];
            arr[mergedIndex, 1] = rightArr[rightIndex, 1];
            rightIndex++;
            mergedIndex++;
        }
    }
}