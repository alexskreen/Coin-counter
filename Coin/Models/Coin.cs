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
        public void DollarCheck()
        {
            while (TotalCost > 100)
            {
                TotalCost -= 100;
                CoinList.Add("a dollar");
            }
        }
        public void FiveDollarCheck()
        {
            while (TotalCost > 500)
            {
                TotalCost -= 500;
                CoinList.Add("a five");
            }
        }
        public void TenDollarCheck()
        {
            while (TotalCost > 1000)
            {
                TotalCost -= 1000;
                CoinList.Add("a ten");
            }
        }
        public void TwentyDollarCheck()
        {
            while (TotalCost > 2000)
            {
                TotalCost -= 2000;
                CoinList.Add("a twenty");
            }
        }
        public void FiftyDollarCheck()
        {
            while (TotalCost > 5000)
            {
                TotalCost -= 5000;
                CoinList.Add("a fifty");
            }
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
            FiftyDollarCheck();
            TwentyDollarCheck();
            TenDollarCheck();
            FiveDollarCheck();
            DollarCheck();
            QuarterCheck();
            DimeCheck();
            NickelCheck();
            PennyCheck();
        }
    }
}