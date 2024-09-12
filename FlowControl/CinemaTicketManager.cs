using MenuHelper;

namespace FlowControl;

/// <summary>
/// A class for calculating and displaying ticket prices.
/// </summary>
internal class CinemaTicketManager
{
    readonly Menu menu = new();

    private const int youthPrice = 80;
    private const int pensionersPrice = 90;
    private const int defaultPrice = 120;

    private int nrOfPeople = 0;
    private int ticketPrice = 0;

    /// <summary>
    /// Prints the ticket price to the console.
    /// </summary>
    public void PrintTicketPrice() => Console.WriteLine($"Number of guests: {nrOfPeople} Ticket price: {ticketPrice}");

    /// <summary>
    /// Prompts the user for data: number of guests and age of guests.
    /// Calculates and prints the total ticket price to the console.
    /// </summary>
    /// <param name="nrOfPeople"></param>
    public void CalculateTicketPrice()
    {
        nrOfPeople = Utilities.PromptUserForValidNumber("Please enter number of guests: ");

        ticketPrice = 0;

        for(int i = 0; i < nrOfPeople; i++)
        {
            int age = PromptUserForAge();
            ticketPrice += GetTicketPriceFromAge(age);
        }
    }

    /// <summary>
    /// Returns the ticket price based on the age.
    /// </summary>
    /// <param name="age">The age of the guest.</param>
    /// <returns>The ticket price.</returns>
    private int GetTicketPriceFromAge(int age)
    {
        int ticketPrice;
        switch (age)
        {
            case < 20:
                ticketPrice = youthPrice;
                break;
            case > 64:
                ticketPrice = pensionersPrice;
                break;
            default:
                ticketPrice = defaultPrice;
                break;
        }

        return ticketPrice;
    }

    /// <summary>
    /// Prompts the user to enter their age and checks for validation.
    /// </summary>
    /// <returns>The age as a valid integer.</returns>
    private int PromptUserForAge()
    {
        return Utilities.PromptUserForValidNumber("Please enter your age: ");
    }
}
