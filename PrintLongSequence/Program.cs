﻿/*Problem 16.* Print Long Sequence
 * Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
 * You might need to learn how to use loops in C# (search in Internet).
 */

using System;


class PrintLongSequence
{
    static void Main()
    {
        int number = 2;
        for (int i = 0; i < 1000; i++)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number++);
            }
            else
            {
                Console.WriteLine("-{0}", number);
                number++;
            }
        }
    }
}