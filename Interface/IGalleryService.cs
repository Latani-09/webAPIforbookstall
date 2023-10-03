using Microsoft.AspNetCore.Mvc;
using webapi.DTOs;
using webapi.Entities;

namespace webapi.Services
{
    public interface IGalleryService
    {


        Task<int> CreatebookAsync(bookDTO book);

        Task<List<Book>> GetAllbooksAsync();

        Task<Book> GetbookAsync(Guid id);

        Task<bool> UpdatebookAsync(    bookDTO book);

        Task<int> DeletebookAsync(Guid id);


    }
}
    
