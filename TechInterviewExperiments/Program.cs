using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechInterviewExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            //reversing an array in place
            //you got it!
            //see below for how

            int[] array1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < array1.Length; i++) //prints initial array
            {
                Console.Write(array1[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0, j = array1.Length - 1; i < array1.Length / 2; i++, j--)
            //i increases from start of array, j decreases from end...
            //only do first half of array, otherwise it will re-replace everything
            {
                int n = array1[i]; //"grabs" the int from the first place
                array1[i] = array1[j]; //sets int in last index place into first index place
                array1[j] = n; //sets the last place as the int originally in the first place

                //it will loop with increasing at start, decreasing at end
            }

            for (int i = 0; i < array1.Length; i++) //prints redone array
            {
                Console.Write(array1[i] + " ");
            }

            Console.ReadLine();

            //now try printing the finobacci sequence up to 1000

            int theNum = 0; //this will be the sum of the two preceeding numbers
            int introNum = 1; //this will be the first of the two preceeding numbers
            int movingNum = 1; //this will be the second of the two preceeding numbers
                               //called it "moving" because it was previously THEnum in the last loop. it "moves" to the second place

            Console.Write("1  1"); //this just prints the first two numbers, which are weird.

            while (theNum <= 1000)
            {
                theNum = introNum + movingNum;
                Console.Write(" " + theNum);
                introNum = movingNum;
                movingNum = theNum;
            }

            Console.ReadLine();

            //you got it (except it shoots one past 1000... maybe a for loop would keep it within bounds)

            int introNum2 = 1;
            int movingNum2 = 1;

            Console.Write("1  1");

            for (int theNum2 = 0; theNum2 <= 1000; theNum2 = introNum2 + movingNum2)
            {
                theNum2 = introNum2 + movingNum2;
                Console.Write(" " + theNum2);
                introNum2 = movingNum2;
                movingNum2 = theNum2;
            }

            Console.ReadLine();

            //yes, the for loop kept it under 1000

            //A unsorted array of integers is given; you need to find the max product formed my multiplying three numbers. 
            //(You cannot sort the array, watch out when there are negative numbers)

            //you need: the array, one spot to use as the known max, one spot to use as each comparison number

            int[] numbers = new int[] { 5, -3, 5, 3, 2, -2, 1, 4 };  //max product of 3 is 4*5*5=100. length =8.

            //can max start at 0? what if all numbers are negatives, compy will always be less than 0
            //maybe run one loop on its own; if result < 0, that becomes max
            //then everything else compares to that number
            int max;
            int compy;

            //I think max needs to start once with product of first three numbers in the array
            //then the loops will start with second, third and fourth, etc...
            //prodect of first three is (temporarily) the max no matter what number it turns out to be

            max = numbers[0] * numbers[1] * numbers[2];

            Console.WriteLine($"Printing product of first three elements, to test it: {max}"); //works
            Console.ReadLine();

            //next couple lines are testing your syntax:
            compy = 5;
            if (compy > max)
            {
                max = compy;
            }

            Console.WriteLine(max);
            Console.ReadLine();

            //think you need nested loops, to mulitple 1st * 2nd, then * 3rd, then *4th etc...
            //how can you not repeat math? or will there be no/little natural overlap?

            for (int j = 0; j < (numbers.Length - 2); j++)
            //j < (numbers.Length-2) is correct because we want to start the final set of loops
            //on the third to last int in the array (knowing that two more ints will follow it)

            {
                for (int k = j + 1; k < (numbers.Length - 1); k++) //start k=j+2 so it starts on the third int in the array
                                                                   //condition is when k< length of array (ie, it starts at third spot, ends in final spot.
                {
                    for (int m = j + 2; m < numbers.Length; m++)
                    {
                        compy = numbers[j] * numbers[k] * numbers[k];
                        Console.WriteLine(compy + " ");


                        if (compy > max)
                        {
                            max = compy;
                        }

                    }
                }



                //wait.. that's gonna get an exception... biggest [] can only be numbers.Length-1... hmm.  FIXED!!!
                //shoudl condition be numbers.Length-1? A: No, Length-2, in the first loop.
                //Why? Because you leave the last two ints in the array to multiply the first int against. 

                //SHOOT not done... this doesn't account for 1st * 3rd * 7th, for example.
                //will it take 3 nested loops?

            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}

