using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coin.Models;

namespace Coin.TestTools
{
    [TestClass]
    public class CoinTests
    {
        [TestMethod]
        public void QuarterCheck_CountingQuarterIncrements_True()
        {
            UserInput newInput = new UserInput(80);
            newInput.QuarterCheck();
            List<string> tempList = new List<string>{"a quarter", "a quarter", "a quarter"};
            CollectionAssert.AreEqual(tempList, newInput.CoinList);
        }
        [TestMethod]
        public void DimeCheck_CountingDimeIncrements_True()
        {
            UserInput newInput = new UserInput(35);
            newInput.DimeCheck();
            List<string> tempList = new List<string>{"a dime", "a dime", "a dime"};
            CollectionAssert.AreEqual(tempList, newInput.CoinList);
        }
        [TestMethod]
        public void NickelCheck_CountingNickelIncrements_True()
        {
            UserInput newInput = new UserInput(19);
            newInput.NickelCheck();
            List<string> tempList = new List<string>{"a nickel", "a nickel", "a nickel"};
            CollectionAssert.AreEqual(tempList, newInput.CoinList);
        }
        [TestMethod]
        public void PennyCheck_CountingPennyIncrements_True()
        {
            UserInput newInput = new UserInput(3);
            newInput.PennyCheck();
            List<string> tempList = new List<string>{"a penny", "a penny", "a penny"};
            CollectionAssert.AreEqual(tempList, newInput.CoinList);
        }
        [TestMethod]
        public void AllCheck_CountingCoinIncrements_True()
        {
            UserInput newInput = new UserInput(8166);
            newInput.AllCheck();
            List<string> tempList = new List<string>{"a fifty", "a twenty", "a ten", "a dollar", "a quarter", "a quarter", "a dime", "a nickel", "a penny"};
            CollectionAssert.AreEqual(tempList, newInput.CoinList);
        }
        [TestMethod]
        public void AllCheck_CountingDollarIncrements_True()
        {
            UserInput newInput = new UserInput(149);
            newInput.DollarCheck();
            List<string> tempList = new List<string>{"a dollar"};
            CollectionAssert.AreEqual(tempList, newInput.CoinList);
        }
        [TestMethod]
        public void AllCheck_CountingFiveDollarIncrements_True()
        {
            UserInput newInput = new UserInput(510);
            newInput.FiveDollarCheck();
            List<string> tempList = new List<string>{"a five"};
            CollectionAssert.AreEqual(tempList, newInput.CoinList);
        }
        [TestMethod]
        public void AllCheck_CountingTenDollarIncrements_True()
        {
            UserInput newInput = new UserInput(1010);
            newInput.TenDollarCheck();
            List<string> tempList = new List<string>{"a ten"};
            CollectionAssert.AreEqual(tempList, newInput.CoinList);
        }
        [TestMethod]
        public void AllCheck_CountingTwentyDollarIncrements_True()
        {
            UserInput newInput = new UserInput(2010);
            newInput.TwentyDollarCheck();
            List<string> tempList = new List<string>{"a twenty"};
            CollectionAssert.AreEqual(tempList, newInput.CoinList);
        }
        [TestMethod]
        public void AllCheck_CountingFiftyDollarIncrements_True()
        {
            UserInput newInput = new UserInput(5010);
            newInput.FiftyDollarCheck();
            List<string> tempList = new List<string>{"a fifty"};
            CollectionAssert.AreEqual(tempList, newInput.CoinList);
        }
    }
}