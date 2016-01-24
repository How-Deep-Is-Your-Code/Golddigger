namespace Golddigger.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Town
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(70)]
        public string Name { get; set; }
    }
}