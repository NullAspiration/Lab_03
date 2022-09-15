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
            option = Int32.Parse(Console.ReadLine());
            MenuChoice(option);

            Console.WriteLine("\nHit Enter to return to menu...");
            Console.ReadLine();
            Console.Clear();
        } while (option != 0);
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("------ Menu ------");
        Console.WriteLine("1. Create a new Person");
        Console.WriteLine("2. View all people");
        Console.WriteLine("5. Create and View Random SSN");
        Console.WriteLine("0. Exit");
        Console.WriteLine("------------------");
    }

    public static void MenuChoice(int option)
    {
        Random random = new Random();
        switch (option)
        {
            case 1:
                people.Add(new Person());
                break;
            case 2:
                foreach (Person p in people)
                {
                    Console.WriteLine(p);
                }
                break;
            case 5:
                Person rando = people[random.Next(people.Count())];
                Console.WriteLine(rando.SSN);
                break;
            case 0:
                Console.WriteLine("See ya!");
                break;
            default:
                Console.WriteLine("Invalid option. Can you read?");
                break;
        }
    }
}