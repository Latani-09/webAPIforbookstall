namespace webapi.DTOs
{
    public class bookDTO
    {
        public int ?Id { get; set; }
        public string Title { get; set; }

        public int? Rating { get; set; }
        public int Price { get; set; }
        public int year { get; set; }


        public string Author { get; set; }
    }
}
