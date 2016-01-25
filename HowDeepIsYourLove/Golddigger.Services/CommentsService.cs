namespace Golddigger.Services
{
    using System;
    using Golddigger.Services.Contracts;
    using Data.Contracts;
    using Models;
    using System.Linq;

    public class CommentsService : ICommentsService
    {
        private readonly IRepository<Comment> commentsRepo;

        public CommentsService(IRepository<Comment> commentsRepo)
        {
            this.commentsRepo = commentsRepo;
        }

        public int Add(string userFromId, string userToId, string comment)
        {
            var commentToAdd = new Comment
            {
                UserFromId = userFromId,
                UserToId = userToId,
                Content = comment,
                CreatedOn = DateTime.Now
            };
            this.commentsRepo.Add(commentToAdd);
            this.commentsRepo.SaveChanges();
            return commentToAdd.Id;
        }

        // TODO Add to admin controls
        public IQueryable<Comment> All()
        {
            return this.commentsRepo.All().OrderBy(x=> x.CreatedOn);
        }

        // For messages on users walls
        public IQueryable<Comment> AllReceivedByUser(string userToId)
        {
            return this.commentsRepo
                .All()
                .Where(x => x.UserToId == userToId)
                .OrderByDescending(x => x.CreatedOn);
        }

        public IQueryable<Comment> AllSentByUser(string userFromId)
        {
            return this.commentsRepo
                .All()
                .Where(x => x.UserFromId == userFromId)
                .OrderByDescending(x => x.CreatedOn);
        }
    }
}