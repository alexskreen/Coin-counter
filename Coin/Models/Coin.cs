using System;
using System.Collections.Generic;

namespace Coin.Models
{
    public class UserInput
    {
        public int TotalCost;
        public List<string> CoinList;

        public UserInput(int totalCost)
        {
            TotalCost = totalCost;
            CoinList = new List<string>{};
        }

        public void QuarterCheck()
        {
            while (TotalCost > 25)
            {
                TotalCost -= 25;
                CoinList.Add("a quarter");
            }
        }
        public void DimeCheck()
        {
            while (TotalCost > 10)
            {
                TotalCost -= 10;
                CoinList.Add("a dime");
            }
        }
        public void NickelCheck()
        {
            while (TotalCost > 5)
            {
                TotalCost -= 5;
                CoinList.Add("a nickel");
            }
        }
        public void PennyCheck()
        {
            while (TotalCost > 0)
            {
                TotalCost -= 1;
                CoinList.Add("a penny");
            }
        }
        public void AllCheck()
        {
            QuarterCheck();
            DimeCheck();
            NickelCheck();
            PennyCheck();
        }
    }
}