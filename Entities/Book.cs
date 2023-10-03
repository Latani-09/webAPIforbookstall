using System.ComponentModel.DataAnnotations;

namespace webapi.Entities
{
    public class Book
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }

        public int? Rating { get; set; }
        public int Price { get; set; }
        public int year { get; set; }
        public string Author { get; set; }

    }
}
