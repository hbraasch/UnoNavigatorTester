// IDataService.cs
public interface IDataService
{
    Task<string> GetDataAsync();
}

// DataService.cs
public class DataService : IDataService
{
    public async Task<string> GetDataAsync()
    {
        await Task.Delay(1000); // Simulate network delay
        return "MainPage";
    }
}
