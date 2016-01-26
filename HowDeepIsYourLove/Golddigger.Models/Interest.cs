namespace Golddigger.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Interest
    {
        private ICollection<UserInfo> userInfo;

        public Interest()
        {
            this.userInfo = new HashSet<UserInfo>();
        }

        [Key]
        public int InterestId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<UserInfo> UserInfo
        {
            get { return this.userInfo; }
            set { this.userInfo = value; }
        }
    }
}