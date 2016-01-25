namespace Golddigger.Services.Contracts
{
    using System.Linq;
    using Golddigger.Models;

    public interface ICommentsService
    {
        int Add(string userFromId, string userToId, string comment);

        IQueryable<Comment> All();

        IQueryable<Comment> AllReceivedByUser(string userToId);

        IQueryable<Comment> AllSentByUser(string userFromId);
    }
}