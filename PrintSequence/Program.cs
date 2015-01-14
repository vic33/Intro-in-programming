/*Problem 9. Print a Sequence
 * Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
*/

using System;



class PrintSequence
{
    static void Main()
    {
        int number = 2;
        for (int i = 0; i < 10; i++)
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
