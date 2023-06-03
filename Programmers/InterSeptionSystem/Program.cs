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
        int n = targets.GetLength(0);
        answer = 0;

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

            if (last >= start && last <= end)
                continue;

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

        Array.Copy(arr, low, leftArr, 0, leftSize);
        Array.Copy(arr, mid + 1, rightArr, 0, rightSize);

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