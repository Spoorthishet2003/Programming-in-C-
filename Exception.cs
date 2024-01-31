/*Develop a C# program to demonstrate Division by Zero and Index Out of Range exceptions*/

using System;
class Program
{
static void Main()
{
    Dividebyzeroexceptionexample();
    Indexoutofrangeexceptionexample();
}
static void Dividebyzeroexceptionexample()
{
    try
    {
        int numerator=10;
        int denominator=0;
        int result=numerator/denominator;
        Console.WriteLine("The result of division is:"+result);
    }
    catch(DivideByZeroException ex)
    {
        Console.WriteLine("Error:" + ex.Message);
    }
}
static void Indexoutofrangeexceptionexample()
{
    try{
        int [] number = {1,2,3,4,5};
        int value = number[10];
        Console.WriteLine("Value at index 10:"+value);
    }
    catch(IndexOutOfRangeException ex)
    {
        Console.WriteLine("Error:" + ex.Message);
    }
}
    
}

