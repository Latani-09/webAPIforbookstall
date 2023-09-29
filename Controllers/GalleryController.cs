using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webapi.Data;
using webapi.DTOs;
using webapi.Services;

namespace webapi.Controllers
{
    [AllowAnonymous]
    public class GalleryController : BaseAPIController
    

        {
           
            private readonly DataContext _dataContext;
        private readonly IGalleryService _galleryService;


            public GalleryController(IGalleryService galleryService,DataContext dataContext)
            {
                _galleryService = galleryService;
                 _dataContext = dataContext;

                
            }


            [HttpPost("movie")]
            [AllowAnonymous]
            public async Task<int> CreateMovieAsync( bookDTO book)
            {
                return await _galleryService.CreateMovieAsync(book);
            }

            [HttpGet("movie")]
            public async Task<List<Entities.Movie>> GetAllMoviesAsync()
            {
                return await _galleryService.GetAllMoviesAsync();
            }

            [HttpGet("movie/{id}")]
            public async Task<Entities.Movie> GetMovieAsync(Guid id
                )
            {
                return await _galleryService.GetMovieAsync(id);
            }

            [HttpPut("movie/{id}")]
            [Authorize]
            public async Task<bool> UpdateMovieAsync([FromBody] bookDTO book)
            {
                return await _galleryService.UpdateMovieAsync(book);
            }

            [HttpDelete("movie/{id}")]
            
            public async Task<int> DeleteMovieAsync(Guid id)
            {
                return await _galleryService.DeleteMovieAsync(id);
            }
    }
}

