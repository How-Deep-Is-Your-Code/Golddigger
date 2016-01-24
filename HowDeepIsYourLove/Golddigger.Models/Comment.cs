namespace Golddigger.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        [MinLength(2)]
        [MaxLength(500)]
        public string Content { get; set; }

        public virtual User UserFrom { get; set; }

        public string UserFromId { get; set; }

        public virtual User UserTo { get; set; }

        public string UserToId { get; set; }

    }
}