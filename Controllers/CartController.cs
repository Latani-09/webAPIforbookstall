using Azure.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata;
using System.Reflection;
using System.Security.Claims;
using webapi.Data;
using webapi.DTOs;
using webapi.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CartController :BaseAPIController  //IDisposable//should be Idisposable??? 
    {
        private const string CartSessionKey = "CartSession";

        public string ShoppingCartId { get; set; }
        private DataContext _dataContext;
        private readonly UserManager<AppUser> _userManager;

        public CartController(DataContext dataContext, UserManager<AppUser> userManager)
        {
            _dataContext = dataContext;
            _userManager = userManager;
        }
        private bool disposed = false;
        /*
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose of managed resources (if any)
                    _dataContext.Dispose();  // Dispose the data context when needed
                }

                disposed = true;
            }
        }
        */

        
        [HttpPost("add-to-cart/{id}")]
        public async void AddToCart(int id,[FromBody]UserDTO userdto)
        {
            var book = _dataContext.Books.SingleOrDefault(
                   p => p.Id == id);
            if (book == null) { Console.WriteLine("book not found"); }
            else {
                Console.WriteLine("item added to cart----------------------------------------------------------------");
                Console.WriteLine(book.title); }
            

     

            // Get the user ID
            
            // Retrieve the product from the database.           
            
            //Console.WriteLine(ShoppingCartId);
            //Console.WriteLine("shopping cart id------------------------------------------------------");
            var cartItem = _dataContext.ShoppingCartItems.SingleOrDefault(
                c =>c.bookId == id && c.userid==userdto.Username);
            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists.                 
                cartItem = new Cartitems
                {
                    ItemId = Guid.NewGuid().ToString(),
                    bookId = id,
                    CartId="cart",
                    userid = userdto.Username,
                    Quantity = 1,
                    DateCreated = DateTime.Now,
                    Price=book.price,
                    title=book.title

                };

                _dataContext.ShoppingCartItems.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart,                  
                // then add one to the quantity.                 
                cartItem.Quantity++;
            }
            _dataContext.SaveChanges();
        }


        /*   public void Dispose()
           {
               Console.WriteLine("delete");
               if (_dataContext != null)
               {
                   _dataContext.Dispose();
                   _dataContext = null;
               }




               // Other actions and cart logic...
           }*/
        /*
          public string GetCartId()
           {
;

               if (!string.IsNullOrWhiteSpace(existingSessionKey))
               {
                   // Session already exists for the user, use the existing session key
                   context.Session.SetString(CartSessionKey, existingSessionKey);
               }
               else
               {
                   // Generate a new random GUID as a session key
                   Guid newCartSessionKey = Guid.NewGuid();
                   context.Session.SetString(CartSessionKey, newCartSessionKey.ToString());
               }
               return CartSessionKey;
           } */
        [HttpDelete("clear")]
        public void Dispose()
        {
            _dataContext.Dispose();
        }

        // Other actions and cart logic...

        /*
                public string GetCartId()
                {
                    HttpContext context = _httpContextAccessor.HttpContext;
                    string cartSessionId = context.Session.GetString(CartSessionKey);

                    if (string.IsNullOrWhiteSpace(cartSessionId))
                    {
                        // Generate a new random GUID as a session ID
                        cartSessionId = Guid.NewGuid().ToString();
                        context.Session.SetString(CartSessionKey, cartSessionId);
                    }

                    return cartSessionId;
                }   */
        [Authorize]
        [HttpGet("view-cart{user_id}")]
        public  async Task<ActionResult<List<Cartitems>>> GetCartItems(string user_id)
        {
             
            List<Cartitems> items=  _dataContext.ShoppingCartItems.Where(
                c=> c.userid == user_id).ToList();
            if (items == null)
            {
                return BadRequest("");
            }

            foreach (Cartitems item in items)
                {
                    Console.WriteLine(item.title);
                }
                return items;
            
          

        }
   
public int GetUserId(string token)
    {
        // Check if the token is missing or empty
        if (string.IsNullOrEmpty(token))
        {
            Console.WriteLine("Token is missing.");
            return -1; // Return a default value indicating an error
        }

        try
        {
            // Decode the token
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

            if (jsonToken == null)
            {
                Console.WriteLine("Invalid token.");
                return -1; // Return a default value indicating an error
            }

            // Retrieve the user ID claim
            var userIdClaim = jsonToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out int userId))
            {
                Console.WriteLine("User ID claim not found or not valid.");
                return -1; // Return a default value indicating an error
            }

            return userId;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while decoding the token: {ex.Message}");
            return -1; // Return a default value indicating an error
        }
    }
    }
}

