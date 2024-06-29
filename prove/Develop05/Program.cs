using System;
using System.Collections;
using System.Diagnostics;
using System.Xml.Linq;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        List<Game> profile = new List<Game>();
        LoadSave account = new LoadSave();

        int profileChoice;

        do
        {
            Console.Clear();
            Console.WriteLine($"Your Score: {score}\n");

            Console.WriteLine("The Game of Success");
            Console.WriteLine(" 1. Quest Selection");
            Console.WriteLine(" 2. Current Quests");
            Console.WriteLine(" 3. Save Game");
            Console.WriteLine(" 4. Load Game");
            Console.WriteLine(" 5. Record Achievement");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select: ");
            profileChoice = int.Parse(Console.ReadLine());

            switch(profileChoice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\nAvailable quest type: ");
                    Console.WriteLine(" 1. Simple Quest");
                    Console.WriteLine(" 2. Eternal Quest");
                    Console.WriteLine(" 3. Checklist Quest");
                    Console.Write("Choose a quest type: ");
                    int goalChoice = int.Parse(Console.ReadLine());

                    switch(goalChoice)
                    {
                        case 1:
                            Console.Clear();
                            Simple simpleQuest = new Simple();
                            simpleQuest.CreateGoal();
                            profile.Add(simpleQuest);
                            Console.WriteLine(" ");
                            break;
                        case 2:
                            Console.Clear();
                            Eternal eternalQuest = new Eternal();
                            eternalQuest.CreateGoal();
                            profile.Add(eternalQuest);
                            Console.WriteLine(" ");
                            break;
                        case 3:
                            Console.Clear();
                            Checklist checklistQuest = new Checklist();
                            checklistQuest.CreateGoal();
                            profile.Add(checklistQuest);
                            Console.WriteLine(" ");
                            break;
                        default:
                            Console.WriteLine("\nInvalid quest selection.\n");
                            break;
                    }
                    break;
                case 2:
                    Console.Clear();
                    
                    int i = 1;
                    Console.WriteLine("\nActive Quests:");
                    foreach (Game quest in profile)
                    {
                        Console.Write(i + ". ");
                        quest.Display();
                        i++;
                    }
                    Console.WriteLine(" ");
                    break;
                case 3:
                    account.SaveGoals(profile, score);
                    break;
                case 4:
                    account.LoadGoals(profile, score);
                    break;
                case 5:
                    Console.Clear();
                    if ( profile.Count() != 0)
                    {
                        i = 1;
                        Console.WriteLine("\nActive Quests:");
                        
                        foreach (Game quest in profile)
                        {
                            Console.Write(i + ". ");
                            quest.Display();
                            i ++;
                        }
                        
                        Console.Write("Which quest did you complete? ");
                        int completed = int.Parse(Console.ReadLine());

                        profile[completed - 1].GoalComplete();
                        score = profile[completed - 1].AddScore(score);
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine("\nNo available quest\n");
                    }
                    break;
                case 6:
                    Console.WriteLine("\nThank you for playing!\n");
                    break;
                default:
                    Console.WriteLine("\nPlease make a valid choice.\n");
                    break;
            }

        } while (profileChoice != 6);
    }
}