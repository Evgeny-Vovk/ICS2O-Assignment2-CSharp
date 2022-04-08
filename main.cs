// Created by: Evgeny
// Created on: Mar 2022
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        //input
        int verticalRadius;
        int horizontalRadius;

        Console.WriteLine("This program finds the area of an ellipse with two radiuses.");
        Console.WriteLine("");

        Console.Write("Enter the horizontal radius(cm): ");
        horizontalRadius = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the vertical radius(cm): ");
        verticalRadius = Convert.ToInt32(Console.ReadLine());

        //process
        double area = (verticalRadius * horizontalRadius) * Math.PI;

        //output
        Console.WriteLine("");
        Console.WriteLine("The area is: " + area.ToString("0.00") + "cm².");

        Console.WriteLine("\nDone.");
    }
}