using Microsoft.AspNetCore.Mvc;
using webapi.DTOs;
using webapi.Entities;

namespace webapi.Services
{
    public interface IGalleryService
    {


        Task<int> CreateMovieAsync(bookDTO book);

        Task<List<Movie>> GetAllMoviesAsync();

        Task<Movie> GetMovieAsync(Guid id);

        Task<bool> UpdateMovieAsync(    bookDTO book);

        Task<int> DeleteMovieAsync(Guid id);


    }
}
    
