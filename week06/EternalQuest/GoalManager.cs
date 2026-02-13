using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    { }

    public void Start()
    {
        string userInput = "";

        while (userInput != "6")
        {
            DipslayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select your choice from the menu: ");
            userInput = Console.ReadLine();
            Console.Clear();

            if (userInput == "1")
            {
                CreateGoal();
                Console.Clear();
            }

            else if (userInput == "2")
            {
                ListGoalDetails();
                Console.ReadKey();
                Console.Clear();
            }

            else if (userInput == "3")
            {
                SaveGoals();
                Console.Clear();
            }

            else if (userInput == "4")
            {
                LoadGoals();
                Console.Clear();
            }

            else if (userInput == "5")
            {
                RecordEvent();
                Console.Clear();
            }

            else if (userInput == "6")
            {
                Console.WriteLine("Good luck with your goal! Keep at it!");
            }

        }
    }

    public void DipslayPlayerInfo()
    {
        int score = _score;
        Console.WriteLine($"You have {score} points");
    }

    public void ListGoalNames()
    {
        int i = 1;

        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");

            i++;
        }
    }

    public void ListGoalDetails()
    {
        int i = 1;

        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailString()}");

            i++;
        }
    }

    public void CreateGoal()
    {
        string shortName = "";

        string description = "";

        int points = 0;

        int target = 0;

        int bonus = 0;

        string input = "";
        Console.WriteLine("Here are the types of goals");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of goal would you like to create?: ");
        input = Console.ReadLine();

        Console.Write("What is the name of your goal?: ");
        shortName = Console.ReadLine();

        Console.Write("What is a short description of it?: ");
        description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal?: ");
        string stringPoints = Console.ReadLine();
        int intPoints = int.Parse(stringPoints);
        points = intPoints;

        if (input == "3")
        {
            Console.Write("How many times does this goal need to be accomplished to obtain a bonus?: ");
            string stringTarget = Console.ReadLine();
            int intTarget = int.Parse(stringTarget);
            target = intTarget;

            Console.Write("How many extra points do you want as a bonus?: ");
            string stringBonus = Console.ReadLine();
            int intBonus = int.Parse(stringBonus);
            bonus = intBonus;
        }

        if (input is "1")
        {
            goals.Add(new SimpleGoal(shortName, description, points));
        }

        if (input is "2")
        {
            goals.Add(new EternalGoal(shortName, description, points));
        }

        if (input is "3")
        {
            goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("What goal did you want to work on?: ");
        string intNum = Console.ReadLine();
        int goalNum = int.Parse(intNum);

        int index = goalNum - 1;
        _score += goals[index].GetPoints();
        goals[index].RecordEvent();

    }

    public void SaveGoals()
    {
        string file = "myGoals.txt";

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            int totScore = _score;
            string totalScore = totScore.ToString();

            outputFile.WriteLine($"{totalScore}");
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals()
    {
        goals.Clear();
        string file = "";
        Console.Write("What is the name of the text file?: ");
        file = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(file);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] type = lines[i].Split(":");
            string[] parts = type[1].Split('|');

            if (type[0] == "SimpleGoal")
            {
                SimpleGoal sGoal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));

                bool.Parse(parts[3]);

                if (bool.Parse(parts[3]) == true)
                {
                    sGoal.SetIsComplete(true);
                }

                goals.Add(sGoal);
            }

            else if (type[0] == "EternalGoal")
            {
                EternalGoal eGoal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));

                goals.Add(eGoal);
            }

            else if (type[0] == "ChecklistGoal")
            {
                ChecklistGoal cGoal = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));

                goals.Add(cGoal);
            }
        }


    }
}