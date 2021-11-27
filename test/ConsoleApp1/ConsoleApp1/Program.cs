using System;
using System.Collections.Generic;

public class Program
{
    void print(int i)
    {
        Console.WriteLine("Printing int: {0}", i);
    }
    void print(double f,string a)
    {
        Console.WriteLine("Printing float: {0}", f + a);
    }
    public static void Main()
    {
        Program p = new Program();
        p.print(5);
        p.print(500.654,"Ramsha");
    }
}