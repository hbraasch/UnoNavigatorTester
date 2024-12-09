using static UnoNavigatorTester.Presentation.ThirdViewModel;

namespace UnoNavigatorTester.Presentation;

public partial class MainViewModel : ObservableObject
{
    private INavigator navigator;
    private readonly IDataService dataService;

    [ObservableProperty]
    private string? name;

    public MainViewModel(
        INavigator navigator)
    {
        this.navigator = navigator;
        Title = App.MainPageData;
        Name = "Value set by MainPage";
    }

    public string? Title { get; }


    [RelayCommand]
    public async Task GoToSecondPage()
    {
        await navigator.NavigateViewModelAsync<SecondViewModel>(this, data: "Hi");
    }

    [RelayCommand]
    public async Task GoDirectlyToThirdPage()
    {
        Name = "";
        var result = await navigator.GetDataAsync<ResponseData>(this, data: new CommandData { Message = "Data from MainPage" });
        Name = result.Message;
    }

}
