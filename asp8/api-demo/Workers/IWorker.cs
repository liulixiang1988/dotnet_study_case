namespace api_demo.Workers;

public interface IWorker
{
    Task<string> DoWorkAsync();
}