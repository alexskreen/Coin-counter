using System;
using Coin.Models;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the amount of cents:");
        int changeInput = int.Parse(Console.ReadLine());
        UserInput newUserInput = new UserInput(changeInput);
        newUserInput.AllCheck();
        foreach (string coin in newUserInput.CoinList)
        {
            Console.WriteLine(coin);
        }
    }
}