using System;
using System.Collections.Generic;
using System.Text;
namespace Program
{
    class Program{
    static void Main()
    {
        int num1, num2, result;
        char option;
        Console.WriteLine("Enter the first number:");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        num2=Convert.ToInt32(Console.ReadLine());   
        
        Console.WriteLine("Main menu");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Mod");

        Console.WriteLine("\n Enter the operation you want to perform:");
        option = Convert.ToChar(Console.ReadLine());

        switch(option)
        {
            case '1':
            result=num1+num2;
            Console.WriteLine(" The resultof Addition is:"+result);
            break;

            case '2':
            result= num1-num2;
            Console.WriteLine("The result of Subtraction is:"+result);
            break;

            case '3':
            result=num1*num2;
            Console.WriteLine(" The result of Multiplication is:"+result);
            break;

            case '4':
            result=num1/num2;
            Console.WriteLine(" The result of division is:"+result);
            break;

            case '5':
            result=num1%num2;
            Console.WriteLine(" The result of Mod is:"+result);
            break;

            default:
            Console.WriteLine("Invalid operation");
            break;
        }
        Console.ReadLine();
    }
    }
}