namespace FlowControl.FlowControlManager;

/// <summary>
/// A basic version of flow control.
/// </summary>
internal class FlowControlManagerBasic : IFlowControlManager
{
    private const int nrOfRepetitions = 10;

    private readonly CinemaTicketManager cinemaTicketManager = new();
    private readonly IterationManager iterationManager = new(nrOfRepetitions) { };

    /// <summary>
    /// Function to print a menu and manage user input.
    /// </summary>
    public void ManageInput()
    {
        Console.WriteLine("Welcome to the main menu.");
        Console.WriteLine("Navigate the meny by typing the corresponding numbers and pressing enter.");
        Console.WriteLine("Options:");
        Console.WriteLine("0: Quit the program.");
        Console.WriteLine("Description: Quits the program.");
        Console.WriteLine("1: Retrieve ticket price.");
        Console.WriteLine("Description: Prompts the user for number of users and age per user. " +
            "Prints the number of participants and total ticket price to the console.");
        Console.WriteLine("2: Repeat a message ten times.");
        Console.WriteLine($"Description: Prompts the user for a string. Prints the string" +
            $" to the console {nrOfRepetitions} times.");
        Console.WriteLine("3: Print the third message.");
        Console.WriteLine("Description: Prompts the user for a string containing at least 3 words separated by spaces. " +
            "Prints the third word to the console.");
        do
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    cinemaTicketManager.CalculateTicketPrice();
                    cinemaTicketManager.PrintTicketPrice();
                    break;
                case "2":
                    iterationManager.RepeatMultipleTimes();
                    break;
                case "3":
                    iterationManager.PrintThirdWord();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        } while (true);
    }
}
