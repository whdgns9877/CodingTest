using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] players, string[] callings)
    {
        Dictionary<string, int> playerPositions = new Dictionary<string, int>();

        for (int i = 0; i < players.Length; i++)
        {
            playerPositions[players[i]] = i;
        }

        for (int i = 0; i < callings.Length; i++)
        {
            int idx = playerPositions[callings[i]];
            if (idx > 0)
            {
                Swap(players, idx, idx - 1);
                playerPositions[players[idx]] = idx;
                playerPositions[players[idx - 1]] = idx - 1;
            }
        }

        return players;
    }

    private void Swap(string[] players, int idx1, int idx2)
    {
        string temp = players[idx1];
        players[idx1] = players[idx2];
        players[idx2] = temp;
    }
}
