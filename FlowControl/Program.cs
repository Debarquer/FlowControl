using FlowControl.FlowControlManager;

internal class Program
{
    private static void Main(string[] args)
    {
        IFlowControlManager controlManager = new FlowControlManagerFancy();
        controlManager.ManageInput();
    }
}