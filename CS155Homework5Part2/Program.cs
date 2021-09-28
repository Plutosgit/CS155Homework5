using System;

namespace CS155Homework5Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Homework 5 Part 2 Coin Toss\n");

            int numTosses = 0, 
                numHeads = 0, 
                numTails = 0,
                nthToss = 0;

            char userkey;

            Console.WriteLine("-------------INPUT--------------");

            while (numTosses < 8)
            {
                nthToss = numTosses + 1;
                Console.Write("\nToss # " + nthToss.ToString() + " - Enter head or tail: ");
                userkey = Console.ReadKey().KeyChar;
                if (userkey.ToString().ToLower() == "h")
                {
                    numHeads++;
                    numTosses++;
                }
                if (userkey.ToString().ToLower() == "t")
                {   numTails++;
                    numTosses++;
                }

            }

            double dpctHeads, dpctTails;
            dpctHeads = ((double)numHeads / (double)numTosses)*100.0;
            dpctTails = ((double)numTails / (double) numTosses)*100.0;

            String spctHeads = String.Format("{0:F1}", dpctHeads);
            String spctTails = String.Format("{0:F1}", dpctTails);

            Console.WriteLine("\n");
            Console.WriteLine("-------------OUTPUT-------------\n");

            Console.WriteLine("Total number of tosses : " + numTosses.ToString());
            Console.WriteLine("Total number of heads  : " + numHeads.ToString());
            Console.WriteLine("Total number of tails  : " + numTails.ToString());
            Console.WriteLine("% Heads : " + spctHeads);
            Console.WriteLine("% Tails : " + spctTails);

        }
    }
}
