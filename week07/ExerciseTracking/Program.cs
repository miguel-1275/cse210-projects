using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        DateTime d1 = new DateTime(2022, 11, 3);
        Running r = new Running(d1, 30, 3.0);
        activities.Add(r);

        DateTime d2 = new DateTime(2022, 11, 3);
        Cycling c = new Cycling(d2, 30, 12.0);
        activities.Add(c);

        DateTime d3 = new DateTime(2022, 11, 3);
        Swimming s = new Swimming(d3, 30, 20);
        activities.Add(s);

        for (int i = 0; i < activities.Count; i++)
        {
            Console.WriteLine(activities[i].GetSummary());
        }
    }
}
