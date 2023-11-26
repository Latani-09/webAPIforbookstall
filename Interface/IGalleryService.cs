using Microsoft.AspNetCore.Mvc;
using webapi.DTOs;
using webapi.Entities;

namespace webapi.Services
{
    public interface IGalleryService
    {


        Task<int> CreatebookAsync(bookDTO book);

        Task<List<Book>> GetAllbooksAsync();

        Task<Book> GetbookAsync(int id);

        Task<bool> UpdatebookAsync(    bookDTO book);

        Task<int> DeletebookAsync(int id);


    }
}
    
