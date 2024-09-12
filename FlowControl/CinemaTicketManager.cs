using MenuHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
            int ticketPrice = CalculateTicketPrice();

            Console.WriteLine($"Ticket price: {ticketPrice}");
        }

        private int CalculateTicketPrice()
        {
            int ticketPrice = 0;

            int age = PromptUserForAge();

            switch(age)
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
