using Lab_03;

public class Program
{
    static List<Person> people = new List<Person>();

    public static void Main(string[] args)
    {
        var option = 0;
        do
        {
            DisplayMenu();
#pragma warning disable CS8604 // Possible null reference argument.
            option = Int32.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
            MenuChoice(option);

            Console.WriteLine("\nPress <Enter> to return to option menu...");
            Console.ReadLine();
            Console.Clear();
        } while (option != 0);
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("[|||||||||||| Menu |||||||||||||]");
        Console.WriteLine("(| 1. Create a new Person      |)");
        Console.WriteLine("(| 2. View all people          |)");
        Console.WriteLine("(| 3. Create & View Random SSN |)");
        Console.WriteLine("(| 0. Exit                     |)");
        Console.WriteLine("[|||||||||||||||||||||||||||||||]");
    }

    public static void MenuChoice(int option)
    {
        if (option < 0)
            Console.WriteLine("You must Enter a number between 0-3." + "\nYou Entered: " + option);
        else if (option > 3)
            Console.WriteLine("You must Enter a number between 0-3." + "\nYou Entered: " + option);
        else
        {
            Random random = new Random();
            switch (option)
            {
                case 1:
                    people.Add(new Person());
                    Console.WriteLine(people.Last());
                    break;
                case 2:
                    foreach (Person p in people)
                    {
                        Console.WriteLine(p);
                    }
                    break;
                case 3:
                    Person rando = people[random.Next(people.Count())];
                    Console.WriteLine(rando.SSN);
                    break;
                case 0:
                    Console.WriteLine("Process Killed...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please make a valid selection");
                    break;
            }
        }

    }
}