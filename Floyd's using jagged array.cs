/*Develop a C# program to generate
and print Floyds Triangle using Jagged arrays.*/

using System;
class Program3{
    static void Main()
    {
        Console.WriteLine("Enter thr number of rows of floyds triangle");
        int numrows = Convert.ToInt32(Console.ReadLine());
        int [][] floydstriangle = new int[numrows][];
        for(int i=0 ; i<numrows; i++)
        {
            floydstriangle[i] = new int[i+1];
        }
        int count = 1;
        for(int i=0; i<numrows; i++)
        {
            for(int j=0; j<=i; j++)
            {
                floydstriangle[i][j]=count++;
            }
        }
        Console.WriteLine("Floyds Triangle");
        for(int i=0; i<numrows; i++)
        {
            for(int j=0; j<=i; j++)
            {
                Console.Write(floydstriangle[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
