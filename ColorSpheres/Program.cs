﻿using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            Color redColor = new Color(255, 0, 0);
            Color blueColor = new Color(0, 0, 255);
            Color greenColor = new Color(0, 255, 0);

            
            Sphere sphere1 = new Sphere(redColor, 5);
            Sphere sphere2 = new Sphere(blueColor, 10);
            Sphere sphere3 = new Sphere(greenColor, 7);

            
            sphere1.Throw();
            sphere1.Throw();
            sphere2.Throw();
            sphere3.Throw();

            
            sphere2.Pop();

            
            Console.WriteLine(sphere1);
            Console.WriteLine(sphere2);
            Console.WriteLine(sphere3);

            
            Console.WriteLine($"Red sphere grey level: {sphere1.GetColor().GetGrey()}");
            Console.WriteLine($"Blue sphere grey level: {sphere2.GetColor().GetGrey()}");
            Console.WriteLine($"Green sphere grey level: {sphere3.GetColor().GetGrey()}");
        }
    }
}
