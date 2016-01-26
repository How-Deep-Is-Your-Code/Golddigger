namespace Golddigger.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserInfo")]
    public class UserInfo
    {
        [Key]
        public int UserInfoId { get; set; }

        private ICollection<Photo> photos;
        private ICollection<Comment> comments;
        private ICollection<Interest> interests;

        public UserInfo()
        {
            this.photos = new HashSet<Photo>();
            this.comments = new HashSet<Comment>();
            this.interests = new HashSet<Interest>();
        }

        public virtual Country Country { get; set; }

        public int CountryId { get; set; }

        public virtual Town Town { get; set; }

        public int TownId { get; set; }

        public virtual AccountType AccountType { get; set; }

        public int AccountTypeId { get; set; }

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