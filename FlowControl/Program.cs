using FlowControl;

internal class Program
{
    private static void Main(string[] args)
    {
        IFlowControlManager controlManager = new FlowControlManagerBasic();
        controlManager.ManageInput();
    }
}