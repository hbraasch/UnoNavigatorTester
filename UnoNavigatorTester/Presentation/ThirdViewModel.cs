

namespace UnoNavigatorTester.Presentation;
public partial class ThirdViewModel : ObservableObject
{
    public class CommandData
    {
        public string Message { get; set; }
    }
    public class ResponseData
    {
        public string Message { get; set; }
    }

    public string? Title { get; }

    INavigator navigator;

    [ObservableProperty]
    public string name;

    public ThirdViewModel(INavigator navigator, CommandData command)
    {
        this.navigator = navigator;
        Title = "ThirdPage";
        Name = command.Message;
    }

    [RelayCommand]
    public async Task GoBack()
    {
        await navigator.NavigateBackWithResultAsync(this, data: new ResponseData { Message = "DataFromThirdPage" });
    }
}

