using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(DateTime.Now, 30, 3.0),       // Example with Running
            new Cycling(DateTime.Now.AddHours(1), 45, 15.0),  // Example with Cycling
            new Swimming(DateTime.Now.AddHours(2), 60, 1.5)   // Example with Swimming
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}