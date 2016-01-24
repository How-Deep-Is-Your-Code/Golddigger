namespace Golddigger.Services.Contracts
{
    public interface ICommentsService
    {
        int Add(string userFromId, string userToId, string comment, int commentId);
    }
}