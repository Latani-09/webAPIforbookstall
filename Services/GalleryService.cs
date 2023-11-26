using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.DTOs;
using webapi.Entities;
using webapi.Interface;

namespace webapi.Services
{
    public class GalleryService:IGalleryService
    {
        private readonly DataContext _bookcontext;
        public GalleryService(DataContext dataContext)
        {
            _bookcontext= dataContext;
 
        }
        public async Task<int> CreatebookAsync(bookDTO book)
        {

            if (book == null || string.IsNullOrEmpty(book?.Title)) // checks Product valid
                throw new Exception("invalid name for book");

            if (await isbookExist(book.Title))
                throw new Exception("The book already exists with the same name. add some more details");

            var bookToCreate = new Book
            {
                title = book.Title,
                author = book.Author,
                price = book.Price,
                year = book.year,



            };
            
            await _bookcontext.Books.AddAsync(bookToCreate);
            await _bookcontext.SaveChangesAsync();     // create client           

            return 1;
        }

        private async Task<bool> isbookExist(string name)
        {
            return await _bookcontext.Books.AnyAsync(x => x.title == name);
        }
        public async Task<List<Book>> GetAllbooksAsync()
        {
            return await _bookcontext.Books.ToListAsync();


        }
        public async Task<bool> UpdatebookAsync(bookDTO book)

        {

            

            //if (IsOtherExists(product))
            //  throw new Exception("The Product already exists with the same name");


            var tobeUpdated = await _bookcontext.Books.FirstOrDefaultAsync(x => x.Id == book.Id);
            if (tobeUpdated == null) // checks Product valid
            {
                throw new Exception("can't add enter valid book name add more details if duplicate exist");
            }
            tobeUpdated.title = book.Title;
            _bookcontext.Books.Update(tobeUpdated);
            await _bookcontext.SaveChangesAsync();

            return true;
        }
        
        public async Task<Book> GetbookAsync(int id)
        {

            var book = await _bookcontext.Books
                                                    .SingleOrDefaultAsync(s => s.Id== id);
            Console.WriteLine(book.title);
            if (book == null)
            {
                throw new Exception($"not found ");
            }
            return book;
        }
        public async Task<int> DeletebookAsync(int id)
        {

            //Get the staff who matches with given Id
            var product = await _bookcontext.Books
                                                    .SingleOrDefaultAsync(s => s.Id ==id);
            if (product == null)
            {
                throw new Exception($"The Staff not found for requested Identifier");
            }
            _bookcontext.Remove(product);
            await _bookcontext.SaveChangesAsync();

            return 1;
        }

        


    }
}
