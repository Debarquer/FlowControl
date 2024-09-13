using MenuHelper;

namespace FlowControl;

/// <summary>
/// A class for calculating and displaying ticket prices.
/// </summary>
internal class CinemaTicketManager
{
    readonly Menu menu = new();

    #region TicketPriceOptionA
    private const int childPrice = 0;
    private const int youthPrice = 80;
    private const int pensionersPrice = 90;
    private const int oldAgePrice = 0;
    private const int defaultPrice = 120;
    #endregion

    #region TicketPriceOptionB
    private struct TicketPrice(int price, int minimumAge, int maximumAge)
    {
        public int Price { get; set; } = price;
        public int MinimumAge { get; set; } = minimumAge;
        public int MaximumAge { get; set; } = maximumAge;

        public bool IsInAgeRange(int age)
        {
            return age >= MinimumAge && age < MaximumAge;
        }
    }

    private TicketPrice[] ticketPrices = [
        new TicketPrice(0, 0, 5),
        new TicketPrice(80, 5, 20),
        new TicketPrice(120, 20, 65),
        new TicketPrice(90, 64, 101),
        new TicketPrice(90, 101, 1000),
    ];
    #endregion

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
            ticketPrice += GetTicketPriceFromAgeOptionA(age);
            //ticketPrice += GetTicketPriceFromAgeOptionB(age);
        }
    }

    /// <summary>
    /// Returns the ticket price based on the age using nest if-else statements.
    /// </summary>
    /// <param name="age">The age of the guest.</param>
    /// <returns>The ticket price.</returns>
    private int GetTicketPriceFromAgeOptionA(int age)
    {
        if (age > 100)
        {
            return oldAgePrice;
        }
        else
        {
            if (age > 64)
            {
                return pensionersPrice;
            }
            else
            {
                if (age < 20)
                {
                    if (age < 5)
                    {
                        return childPrice;
                    }
                    else
                    {
                        return youthPrice;
                    }
                }
            }
        }

        return defaultPrice;
    }

    /// <summary>
    /// Returns the ticket price based on the age.
    /// </summary>
    /// <param name="age">The age of the guest.</param>
    /// <returns>The ticket price.</returns>
    private int GetTicketPriceFromAgeOptionB(int age)
    {
        int ticketPrice;
        switch (age)
        {
            case < 5:
                ticketPrice = childPrice; 
                break;
            case < 20:
                ticketPrice = youthPrice;
                break;
            case > 100:
                ticketPrice = oldAgePrice;
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
    /// Alternative GetTicketPriceFromAge method using a foreach loop instead of a switch.
    /// </summary>
    /// <param name="age">The age of the guest.</param>
    /// <returns>The ticket price.</returns>
    /// <exception cref="Exception">If the age is not found in the ticketPrices list.</exception>
    private int GetTicketPriceFromAgeOptionC(int age)
    {
        foreach(TicketPrice ticketPrice in ticketPrices)
        {
            if (ticketPrice.IsInAgeRange(age)) return ticketPrice.Price;
        }

        throw new Exception("GetTicketPriceFromAgeOptionB error: Invalid age");
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
