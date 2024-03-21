namespace api_demo.Workers;

public class DreamWorker: IWorker
{
    public Task<string> DoWorkAsync()
    {
        return Task.FromResult("Dream");
    }
}