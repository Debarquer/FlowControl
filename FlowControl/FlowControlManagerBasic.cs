﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class FlowControlManagerBasic : IFlowControlManager
    {
        CinemaTicketManager cinemaTicketManager = new();

        public void ManageInput()
        {
            Console.WriteLine("Welcome to the main menu.");
            Console.WriteLine("Navigate the meny by typing the corresponding numbers and pressing enter.");
            Console.WriteLine("Options:");
            Console.WriteLine("0: Quit the program");
            Console.WriteLine("1: Retrieve ticket price");

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
                        cinemaTicketManager.PrintTicketPrice();
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            } while (true);
        }
    }
}
