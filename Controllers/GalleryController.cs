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


            [HttpPost("book")]
            [AllowAnonymous]
            public async Task<int> CreatebookAsync( bookDTO book)
            {
                return await _galleryService.CreatebookAsync(book);
            }

            [HttpGet("book")]
            public async Task<List<Entities.Book>> GetAllbooksAsync()
            {
                return await _galleryService.GetAllbooksAsync();
            }

            [HttpGet("book/{id}")]
            public async Task<Entities.Book> GetbookAsync(Guid id
                )
            {
                return await _galleryService.GetbookAsync(id);
            }

            [HttpPut("book/{id}")]
            [Authorize]
            public async Task<bool> UpdatebookAsync([FromBody] bookDTO book)
            {
                return await _galleryService.UpdatebookAsync(book);
            }

            [HttpDelete("book/{id}")]
            
            public async Task<int> DeletebookAsync(Guid id)
            {
                return await _galleryService.DeletebookAsync(id);
            }
    }
}

