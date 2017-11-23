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

            int[] array1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < array1.Length; i++) //prints initial array
            {
                Console.Write(array1[i]+ " ");            
            }

            Console.WriteLine();

            for (int i = 0, j = array1.Length - 1; i < array1.Length/2; i++, j--)
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

            for (int theNum2 = 0; theNum2 <= 1000; theNum2=introNum2 + movingNum2)
            {
                theNum2 = introNum2 + movingNum2;
                Console.Write(" " + theNum2);
                introNum2 = movingNum2;
                movingNum2 = theNum2;
            }

            Console.ReadLine();

            //yes, the for loop kept it under 1000
        }
    }
}
