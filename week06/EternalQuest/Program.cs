using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine();
            Console.WriteLine("You have " + manager.GetScore() + " points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string type = Console.ReadLine();

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    manager.AddGoal(goal);
                }
                else if (type == "2")
                {
                    EternalGoal goal = new EternalGoal(name, description, points);
                    manager.AddGoal(goal);
                }
                else if (type == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    manager.AddGoal(goal);
                }
                else
                {
                    Console.WriteLine("Invalid goal type.");
                }
            }
            else if (choice == "2")
            {
                List<Goal> goals = manager.GetGoals();
                Console.WriteLine("The goals are:");
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + goals[i].GetDetailsString());
                }
            }
            else if (choice == "3")
            {
                Console.Write("Enter the file name to save goals: ");
                string fileName = Console.ReadLine();
                manager.SaveGoals(fileName);
                Console.WriteLine("Goals saved successfully.");
            }
            else if (choice == "4")
            {
                Console.Write("Enter the file name to load goals: ");
                string fileName = Console.ReadLine();
                manager.LoadGoals(fileName);
                Console.WriteLine("Goals loaded successfully.");
            }
            else if (choice == "5")
            {
                List<Goal> goals = manager.GetGoals();
                Console.WriteLine("The goals are:");
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + goals[i].GetShortName());
                }

                Console.Write("Which goal did you accomplish? ");
                int index = int.Parse(Console.ReadLine()) - 1;

                if (index >= 0 && index < goals.Count)
                {
                    int points = goals[index].RecordEvent();
                    manager.AddScore(points);
                    Console.WriteLine("Congratulations! You have earned " + points + " points!");
                    Console.WriteLine("You now have " + manager.GetScore() + " points.");
                }
                else
                {
                    Console.WriteLine("Invalid goal number.");
                }
            }
            else if (choice == "6")
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
