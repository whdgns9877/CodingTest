using System;
using System.Collections.Generic;
using System.Linq;

namespace MultilevelToothbrushSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] enroll = { "john", "mary", "edward", "sam", "emily", "jaimie", "tod", "young" };
            string[] referral = { "-", "-", "mary", "edward", "mary", "mary", "jaimie", "edward" };
            string[] seller = { "young", "john", "tod", "emily", "mary" };
            int[] amount = { 12, 4, 2, 5, 10 };
            Console.WriteLine(solution.solution(enroll, referral, seller, amount));
        }
    }

    public class Solution
    {
        Dictionary<string, int> myReward;
        Dictionary<string, string> myParent;
        string[] seller;
        int[] amount;
        public int[] solution(string[] enroll, string[] referral, string[] seller, int[] amount)
        {
            int[] answer = new int[enroll.Length];
            this.seller = seller;
            this.amount = amount;
            myReward = new Dictionary<string, int>();
            myParent = new Dictionary<string, string>();

            for (int i = 0; i < enroll.Length; i++)
            {
                myReward.Add(enroll[i], 0);
            }

            for (int i = 0; i < referral.Length; i++)
            {
                if (!referral[i].Equals("-"))
                {
                    myParent.Add(enroll[i], referral[i]);
                }
            }

            for (int i = 0; i < amount.Length; i++)
            {
                myReward[seller[i]] += amount[i] * 90;

                if (myParent.ContainsKey(seller[i]))
                {
                    myReward[myParent[seller[i]]] += amount[i] * 10;
                    GiveBackToParent(myParent[seller[i]], amount[i] * 10);
                }
            }

            return myReward.Values.ToArray();
        }

        private void GiveBackToParent(string child, int money)
        {
            int giveBackMoney = (int)(money * 0.1f);

            if (giveBackMoney > 0)
            {
                myReward[child] -= giveBackMoney;
            }
            else
            {
                return;
            }

            if (myParent.ContainsKey(child))
            {
                myReward[myParent[child]] += giveBackMoney;
                GiveBackToParent(myParent[child], giveBackMoney);
            }
        }
    }
}
