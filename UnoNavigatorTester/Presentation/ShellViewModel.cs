namespace UnoNavigatorTester.Presentation;

public class ShellViewModel
{
    private readonly INavigator _navigator;
    IDataService dataService;

    public ShellViewModel(
        INavigator navigator)
    {
        _navigator = navigator;
        // Add code here to initialize or attach event handlers to singleton services

    }

}
