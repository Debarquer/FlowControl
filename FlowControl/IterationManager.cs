using MenuHelper;

namespace FlowControl;

/// <summary>
/// A class for testing various iteration methods.
/// </summary>
/// <param name="repetitions">The number of iterations used in the RepeatMultipleTimes method.</param>
internal class IterationManager(int repetitions = 10)
{
    private int Repetitions { get; set; } = repetitions;

    /// <summary>
    /// Prompts the user for a string.
    /// Prints the string to the console Repetitions number of times.
    /// </summary>
    public void RepeatMultipleTimes()
    {
        string input = Utilities.PromptUserForString("Please enter a string: ");

        for(int i = 0; i < Repetitions; i++)
        {
            Console.Write($"{i + 1}. {input}" + (i == Repetitions-1 ? "" : ", "));
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Prompts the user for a string, containing at least 3 words separated by spaces.
    /// Prints the third word to the console.
    /// </summary>
    public void PrintThirdWord()
    {
        string input = Utilities.PromptUserForValidInput(
            "Please enter a string, containing at least 3 words separated by spaces: ",
            (string s) => s.Split(' ').Length >= 3,
            "Please enter at least 3 words.");

        var split = input.Split(' ').Where(x => x != "").ToArray();
        string thirdWord = split[2];

        Console.WriteLine($"Full string: {input}");
        Console.WriteLine($"The third word: {thirdWord}");
    }
}
