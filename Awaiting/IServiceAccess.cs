namespace Awaiting
{
    public interface IServiceAccess
    {
        Task<string> GetDataAsync();

        Task NoReturn();
    }
}