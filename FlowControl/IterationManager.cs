using MenuHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class IterationManager(int repetitions = 10)
    {
        int Repetitions { get; set; } = repetitions;

        public void RepeatTenTimes()
        {
            string input = Utilities.PromptUserForString("Please enter a string: ");

            for(int i = 0; i < Repetitions; i++)
            {
                Console.Write($"{i + 1}. {input}" + (i == Repetitions-1 ? "" : ", "));
            }
            Console.WriteLine();
        }

        public void PrintThirdWord()
        {
            string input = Utilities.PromptUserForValidInput(
                "Please enter a string, containing at least 3 words seperated by spaces: ",
                (string s) => s.Split(' ').Length >= 3,
                "Please enter at least 3 words.");

            var split = input.Split(' ');
            string thirdWord = split[2];

            Console.WriteLine($"Full string: {input}");
            Console.WriteLine($"The third word: {thirdWord}");
        }
    }
}
