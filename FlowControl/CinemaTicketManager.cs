using MenuHelper;

namespace FlowControl
{
    internal class CinemaTicketManager
    {
        Menu menu = new();

        const int youthPrice = 80;
        const int pensionersPrice = 90;
        const int defaultPrice = 120;

        public void PrintTicketPrice()
        {
            int nrOfPeople = Utilities.PromptUserForValidNumber("Please enter number of guests: ");

            int ticketPrice = CalculateTicketPrice(nrOfPeople);

            Console.WriteLine($"Number of guests: {nrOfPeople} Ticket price: {ticketPrice}");
        }

        private int CalculateTicketPrice(int nrOfPeople)
        {
            int ticketPrice = 0;


            for(int i = 0; i < nrOfPeople; i++)
            {
                int age = PromptUserForAge();
                ticketPrice += GetTicketPriceFromAge(age);
            }

            return ticketPrice;
        }

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

        private int PromptUserForAge()
        {
            return Utilities.PromptUserForValidNumber("Please enter your age: ");
        }
    }
}
