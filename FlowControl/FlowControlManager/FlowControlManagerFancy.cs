namespace FlowControl.FlowControlManager;

/// <summary>
/// A more fancy version of flow control, using the MenuHelper project.
/// </summary>
internal class FlowControlManagerFancy : IFlowControlManager
{
    private const int nrOfRepetitions = 10;

    private readonly CinemaTicketManager cinemaTicketManager = new();
    private readonly IterationManager iterationManager = new(nrOfRepetitions) { };

    MenuHelper.Menu.MenuOption[] menuOptions = [];

    MenuHelper.Menu menu = new();

    /// <summary>
    /// Function to print a menu and manage user input.
    /// </summary>
    internal FlowControlManagerFancy()
    {
        menuOptions = [
            new MenuHelper.Menu.MenuOption(
                "0",
                "Quit the program.",
                () => Environment.Exit(0),
                "Description: Quits the program."),
            new MenuHelper.Menu.MenuOption(
                "1",
                "Retrieve ticket price.",
                () => {
                    cinemaTicketManager.CalculateTicketPrice();
                    cinemaTicketManager.PrintTicketPrice();
                },
                "Description: Prompts the user for number of users and age per user." +
                " Prints the number of participants and total ticket price to the console."),
            new MenuHelper.Menu.MenuOption(
                "2",
                "Repeat a message ten times.",
                () => iterationManager.RepeatMultipleTimes(),
                $"Description: Prompts the user for a string. Prints the string" +
                $" to the console {nrOfRepetitions} times."),
            new MenuHelper.Menu.MenuOption(
                "3",
                "Print the third message.",
                () => iterationManager.PrintThirdWord(),
                "Description: Prompts the user for a string containing at least 3 words separated by spaces." +
                " Prints the third word to the console."),
         ];
    }

    /// <summary>
    /// Function to print a menu and manage user input.
    /// </summary>
    public void ManageInput()
    {
        Console.WriteLine("Welcome to the main menu.");
        Console.WriteLine("Navigate the meny by typing the corresponding numbers and pressing enter.");

        menu.ShowMenu(menuOptions);
    }
}
