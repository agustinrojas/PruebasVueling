using System;
using System.IO;
//using System.Diagnostics;

public class Example
{
    public static void Main()
    {

        
        string value = Environment.GetEnvironmentVariable("ARB");
        

        Console.WriteLine("Informacion de la variable:   " + value);
        Console.ReadLine();
    }
}