﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Handles the money in either register or customers hand
    /// </summary>
    public class Handler
    {
        /// <summary>
        /// The cash in register
        /// </summary>
        public static CashRegisterModelView Register { get; private set; } = new CashRegisterModelView();

        /// <summary>
        /// The cash given
        /// </summary>
        public CashGiven cashGiven { get; private set; } = new CashGiven();

        /// <summary>
        /// The total amount
        /// </summary>
        public double Total { get; set; }

        /// <summary>
        /// Add the hand to the register and calculate how much change we need to give.
        /// </summary>
        /// <param name="total">Total amount required to complete transaction</param>
        /// <returns>String of bill/coin values to return back to customer</returns>
        public string CalculateChangeToGiveBack(double total)
        {
            Total = total;

            double changeToGiveBack = cashGiven.TotalValueGiven - total;

            Register.Pennies += cashGiven.Pennies;
            Register.Nickels += cashGiven.Nickels;
            Register.Dimes += cashGiven.Dimes;
            Register.Quarters += cashGiven.Quarters;
            Register.HalfDollars += cashGiven.HalfDollars;
            Register.Dollars += cashGiven.Dollars;
            Register.Ones += cashGiven.Ones;
            Register.Twos += cashGiven.Twos;
            Register.Fives += cashGiven.Fives;
            Register.Tens += cashGiven.Tens;
            Register.Twenties += cashGiven.Twenties;
            Register.Fifties += cashGiven.Fifties;
            Register.Hundreds += cashGiven.Hundreds;


            StringBuilder changeAmounts = new StringBuilder();

            Register.Hundreds -= 
                DetermineChangeAmounts(Register.Hundreds, 100.00, changeAmounts, ref changeToGiveBack, new string[] { "Hundred", "Hundreds" });
            Register.Fifties -= 
                DetermineChangeAmounts(Register.Fifties, 50.00, changeAmounts, ref changeToGiveBack, new string[] { "Fifty", "Fifties" });
            Register.Twenties -= 
                DetermineChangeAmounts(Register.Twenties, 20.00, changeAmounts, ref changeToGiveBack, new string[] { "Twenty", "Twenties" });
            Register.Tens -= 
                DetermineChangeAmounts(Register.Tens, 10.00, changeAmounts, ref changeToGiveBack, new string[] { "Ten", "Tens" });
            Register.Fives -= 
                DetermineChangeAmounts(Register.Fives, 5.00, changeAmounts, ref changeToGiveBack, new string[] { "Five", "Fives" });
            Register.Twos -= 
                DetermineChangeAmounts(Register.Twos, 2.00, changeAmounts, ref changeToGiveBack, new string[] { "Two", "Twos" });
            Register.Ones -= 
                DetermineChangeAmounts(Register.Ones, 1.00, changeAmounts, ref changeToGiveBack, new string[] { "One", "Ones" });          
            Register.Dollars -= 
                DetermineChangeAmounts(Register.Dollars, 1.00, changeAmounts, ref changeToGiveBack, new string[] { "Dollar Coin", "Dollar Coins" });            
            Register.HalfDollars -= 
                DetermineChangeAmounts(Register.HalfDollars, 0.50, changeAmounts, ref changeToGiveBack, new string[] { "Half-Dollar", "Half-Dollars" });
            Register.Quarters -= 
                DetermineChangeAmounts(Register.Quarters, 0.25, changeAmounts, ref changeToGiveBack, new string[] { "Quarter", "Quarters" });
            Register.Dimes -= 
                DetermineChangeAmounts(Register.Dimes, 0.10, changeAmounts, ref changeToGiveBack, new string[] { "Dime", "Dimes" });
            Register.Nickels -= 
                DetermineChangeAmounts(Register.Nickels, 0.05, changeAmounts, ref changeToGiveBack, new string[] { "Nickel", "Nickels" });
            Register.Pennies -= 
                DetermineChangeAmounts(Register.Pennies, 0.01, changeAmounts, ref changeToGiveBack, new string[] { "Penny", "Pennies" });

            if (changeToGiveBack >= 0.01) throw new InvalidOperationException();
            else
            {
                return changeAmounts.ToString();
            }
        }
        /// <summary>
        /// Find the number of currency to return back to customer as change
        /// </summary>
        /// <param name="numberAvailable">Number of available coins or bills</param>
        /// <param name="valueOfDenomination">The worth of this denomination</param>
        /// <param name="changeAmounts">Change amounts to give</param>
        /// <param name="changeToGiveBack">Total cost reference</param>
        /// <param name="denominationName">An array of strings for single and multiple denomination types</param>
        /// <returns>Number of this denomination</returns>
        private int DetermineChangeAmounts(int numberOfChangeAvailable, double valueOfDenomination, StringBuilder changeAmounts, ref double changeToGiveBack, string[] denominationName)
        {
            int neededAmount = (int)(changeToGiveBack / valueOfDenomination);
            int specificNumber = Math.Min(numberOfChangeAvailable, neededAmount);

            if (specificNumber == 1) changeAmounts.AppendLine(specificNumber + " " + denominationName[0]);
            if (specificNumber > 1) changeAmounts.AppendLine(specificNumber + " " + denominationName[1]);

            changeToGiveBack -= specificNumber * valueOfDenomination;
            return specificNumber;
        }
    }
}
