namespace Golddigger.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}