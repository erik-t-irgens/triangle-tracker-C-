using System;
using System.Collections.Generic;
using System.Threading;

class Triangle 
{

     public Triangle(int a, int b, int c)
    {
        int A = a;
        int B = b;
        int C = c;

    }

    public bool IsItATriangle(int a, int b, int c)
    {
        return ((a + b )> c && (a + c) > b && (b + c) > a);
    }
}


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, user. I'm here to take information from you...");
        Thread.Sleep(2000);
        Console.WriteLine("Let's construct some TRIANGLEs...");
        Thread.Sleep(2000);
        Console.WriteLine("Give me the length of each of the SIDES of our TRIANGLE...");
        Thread.Sleep(2000);
        Console.WriteLine("Side One: ");
        string sideOne = Console.ReadLine();
        Thread.Sleep(2000);
        Console.WriteLine("Side Two: ");
        string sideTwo = Console.ReadLine();
        Thread.Sleep(2000);
        Console.WriteLine("Side Three: ");
        string sideThree = Console.ReadLine();
        Thread.Sleep(2000);
        Console.WriteLine("Good. Now. Let's see what kind of TRIANGLE it is...");
        Thread.Sleep(2000);

        int a = int.Parse(sideOne);
        int b = int.Parse(sideTwo);
        int c = int.Parse(sideThree);

        Triangle userTriangle = new Triangle (a, b, c);

        if (userTriangle.IsItATriangle(a, b, c))
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Your TRIANGLE is EQUILLATERAL...");
                
                
            }
            else if ((a == b && b != c) || (a == c && c != b) || (b == c && c != a))
            {
                Console.WriteLine("Your TRIANGLE is ISOSCELES...");
            }
            else if (a != b && b != c && a != c)
            {
                Console.WriteLine("Your TRIANGLE is SCALENE...");
            }
        } else {
            Console.WriteLine("Your sides cannot make a valid TRIANGLE!");
        }

        Thread.Sleep(2000);
        Console.WriteLine("Would you like to build another? (Yes/No)");
        string answer = Console.ReadLine();
        if (answer == "Yes" || answer == "yes")
        {
            Main();
        }
        Console.WriteLine("Goodbye!");
    }

}