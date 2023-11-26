using System.ComponentModel.DataAnnotations;

namespace webapi.Entities
{
    public class Book
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string title { get; set; }
        public string author { get; set; }
        public string country { get; set; }
        public string imageLink { get; set; }
        public string language { get; set; }
        public string? link { get; set; }
        public int price { get; set; }
        public int year { get; set; }
        public int pages { get; set; }



    }
}
