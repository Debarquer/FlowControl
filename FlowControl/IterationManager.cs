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
    }
}
