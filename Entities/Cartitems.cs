using System.ComponentModel.DataAnnotations;

namespace webapi.Entities
{
    public class Cartitems
    { 
            [Key]
            public string ItemId { get; set; }

            public string CartId { get; set; }
            
            public string userid { get; set; }


            public int Quantity { get; set; }

            public System.DateTime DateCreated { get; set; }

            public int bookId { get; set; }

            public  Book Product { get; set; }
            
            public string title { get; set; }

            public  decimal Price { get; set; }

        
    }
}
