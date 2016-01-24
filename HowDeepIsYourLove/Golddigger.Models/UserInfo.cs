namespace Golddigger.Models
{
    using System.Collections.Generic;

    public class UserInfo
    {
        private ICollection<Photo> photos;
        private ICollection<Comment> comments;
        private ICollection<Interest> photos;

        public UserInfo()
        {
            this.photos = new HashSet<Photo>();
            this.comments = new HashSet<Comment>();
        }

        public virtual Country Country { get; set; }

        public virtual Town Town { get; set; }

        public virtual AccountType AccountType { get; set; }

        public virtual ICollection<Interest> Interests
        {
            get { return this.interests; }
            set { this.interests = value; }
        }

        public virtual ICollection<Photo> Photos
        {
            get { return this.photos; }
            set { this.photos = value; }
        }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }
    }
}
