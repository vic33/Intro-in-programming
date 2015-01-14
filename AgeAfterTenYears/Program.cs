﻿/*Problem 15.* Age after 10 Years
 * Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
 */

using System;


class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your birthday in format(dd.mm.yyyy): ");
        DateTime userBirthday = DateTime.Parse(Console.ReadLine());
        long resulut = DateTime.Today.Subtract(userBirthday).Ticks;
        Console.WriteLine("You are {0} years old.", new DateTime(resulut).Year - 1);
        Console.WriteLine("After 10 years you will be {0} years old.", new DateTime(resulut).AddYears(10).Year - 1);
    }
}
