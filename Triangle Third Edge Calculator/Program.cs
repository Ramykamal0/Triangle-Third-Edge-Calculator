using System;
//Create a function that Find Valid Triangle Side Range, where the side lengths are all integers.

namespace Triangle_Third_Edge_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter side 1 and side 2");

            int side1 = Convert.ToInt32(Console.ReadLine());
            int side2 = Convert.ToInt32(Console.ReadLine());
            int[] result = FindValidTriangleSideRange(side1, side2);

            Console.WriteLine("Valid third sides are:");

            foreach (int side in result)
            {
                Console.WriteLine(side);
            }
        }

        static int[] FindValidTriangleSideRange(int side1, int side2)
        {
            int minSide = Math.Abs(side1 - side2) + 1;
            int maxSide = side1 + side2 - 1;

            int[] validSides = new int[maxSide - minSide + 1];

            for (int i = 0; i < validSides.Length; i++)
            {
                validSides[i] = minSide + i;
            }

            return validSides;
        }
    }
 }
