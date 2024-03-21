namespace api_demo.Workers;

public class DummyWorker: IWorker
{
    public Task<string> DoWorkAsync()
    {
        return Task.FromResult("Dummy");
    }
}