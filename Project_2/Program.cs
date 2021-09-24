/*
 * Project_2: This program will use a while loop to cycle through user selection and return the statistics of the users choices
 * Name: Spencer Unitt
 * Module: Homework 5, Project 2
 * Problem Statement: Determine how many times the user selects heads or tails
 * 
 * Algorithm: 
 *  1. Create int variables for count, heads, and tails. These are counters for the program
 *     Two double that will be used to show the stats for heads and tails
 *     A char variable named toss for user selection
 *  2. Use a while loop that runs 8 times
 *  3. In the while loop prompt the user to enter 'h' or 't' and set toss equal to it
 *  4. if the toss is equal to h increment the heads counter by 1 
 *     if the toss is equal to t increment the tails counter by 1
 *  5. At the end of the while loop, increment the count by 1
 *  6. Use the equation coin * 100 / count to determine the average.
 *  7. Display the total amount of heads and tails selected. Show the stats for each as well
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables used for counters
            int count = 0, heads = 0, tails = 0;

            // Holds the stats for heads and tails
            double heads_stats, tails_stats;
            char toss;
            
            // Array that makes the program easier to read for the user.
            string[] nums = new string[] {"First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth"};

            // Instruct user what to do
            Console.WriteLine("Enter 'h' or 't' (heads or tails) for each toss");
            // Runs 8 times
            while(count < 8)
            {
                // Prompts user for selection
                Console.WriteLine(nums[count] + " toss: ");
                // reads the selection and converts it to lower case 
                toss = char.Parse(Console.ReadLine());
                toss = char.ToLower(toss);                

                // depending on the selection determine which counter to increment
                if(toss == 'h')
                {
                    heads++;
                }
                else if(toss == 't')
                {
                    tails++;
                }
                else
                {
                    // print error message
                    Console.WriteLine("Not a valid choice, try again");
                    count--;
                }

                // increment counter by 1
                count++;
            }

            // calculate the % of times heads and tails were selected
            heads_stats = heads * 100 / count;
            tails_stats = tails * 100 / count;

            // displays the results to the user
            Console.WriteLine("\n");
            Console.WriteLine("Number of heads: " + heads);
            Console.WriteLine("Number of tails: " + tails + "\n");

            Console.WriteLine("Percent heads was selected: " + heads_stats.ToString("F"));
            Console.WriteLine("Percent tails was selected: " + tails_stats.ToString("F"));


            Console.ReadLine();
        }
    }
}
