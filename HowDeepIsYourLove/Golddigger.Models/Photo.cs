namespace Golddigger.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public byte[] PhotoContent { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}