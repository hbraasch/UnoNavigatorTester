using Microsoft.UI.Dispatching;
using Uno.Extensions.Navigation;
using static UnoNavigatorTester.Presentation.ThirdViewModel;

namespace UnoNavigatorTester.Presentation
{
    public partial class SecondViewModel:ObservableObject
    {
        INavigator navigator;

        public string? Title { get; }

        [ObservableProperty]
        public string name;

        public SecondViewModel(INavigator navigator, string command, ResponseData response)
        {
            this.navigator = navigator;

            if (response != null)
            {
                Title = "SecondPage";
                Name = "Value set by incorrectly instantiated viewmodel";
            }
            else
            {
                Title = "SecondPage";
                Name = "Value set by SecondPage";
            }
        }

        [RelayCommand]
        public async Task GoToThirdPage()
        {
            Name = "";

            var result = await navigator.GetDataAsync<ResponseData>(this, data: new CommandData { Message = "Data from SecondPage" });
            Name = result.Message;
        }

        [RelayCommand]
        public async Task GoBack()
        {
            await navigator.NavigateBackAsync(this);
        }
    }


}



