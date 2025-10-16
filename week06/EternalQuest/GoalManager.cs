using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }

    public void AddScore(int points)
    {
        _score = _score + points;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            if (type == "SimpleGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                bool complete = bool.Parse(data[3]);

                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (complete)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                int bonus = int.Parse(data[3]);
                int target = int.Parse(data[4]);
                int completed = int.Parse(data[5]);
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);

                for (int c = 0; c < completed; c++)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
        }
    }
}
