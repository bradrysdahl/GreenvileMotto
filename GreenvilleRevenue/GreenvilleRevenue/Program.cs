//Program written by: Brad Rysdahl
//Program date: 1/16/18
//Program description: This program gets input from the user for number
//of people entered into a competition this year and last year. It then
//calculates the total revenue generated from this year's competition and
//tells the user whether this year's attendance is higher than last year's.

using System;
using static System.Console;
class GreenvilleRevenue
{
    static void Main()
    {
        string contestantsLastYearAsString;
        string contestantsThisYearAsString;
        double contestantsLastYear;
        double contestantsThisYear;
        double expectedRevenue;
        double fee = 25;

        Write("Enter the number of contestants in last year's competition >> ");
        contestantsLastYearAsString = ReadLine();
        contestantsLastYear = Convert.ToDouble(contestantsLastYearAsString);
        Write("Enter the number of contestants in this year's competition >> ");
        contestantsThisYearAsString = ReadLine();
        contestantsThisYear = Convert.ToDouble(contestantsThisYearAsString);
        expectedRevenue = contestantsThisYear * fee;
        WriteLine("The number of contestants in last year's competition was {0}. The number of contestants " +
        "in this year's competition is {1}. The revenue expected for this year's competition is {2}.", contestantsLastYear,
        contestantsThisYear, expectedRevenue.ToString("C"));
        if (contestantsThisYear > contestantsLastYear)
        {
            WriteLine("The number of contestants this year is greater than the number of contestants last year.");
        }
        else
        {
            WriteLine("The number of contestants this year is greater than the number of contestants last year.");
        }
    }
}
