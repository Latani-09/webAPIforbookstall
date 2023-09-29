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
        private readonly DataContext _movieContext;
        public GalleryService(DataContext dataContext)
        {
            _movieContext= dataContext;
 
        }
        public async Task<int> CreateMovieAsync(bookDTO movie)
        {

            if (movie == null || string.IsNullOrEmpty(movie?.Title)) // checks Product valid
                throw new Exception("invalid name for movie");

            if (await ismovieExist(movie.Title))
                throw new Exception("The movie already exists with the same name. add some more details");

            var movieToCreate = new Movie
            {
                Title = movie.Title,
                Author = movie.Author,
                Price = movie.Price,
                year = movie.year,



            };
            
            await _movieContext.Movies.AddAsync(movieToCreate);
            await _movieContext.SaveChangesAsync();     // create client           

            return 1;
        }

        private async Task<bool> ismovieExist(string name)
        {
            return await _movieContext.Movies.AnyAsync(x => x.Title == name);
        }
        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            return await _movieContext.Movies.ToListAsync();


        }
        public async Task<bool> UpdateMovieAsync(bookDTO movie)

        {

            

            //if (IsOtherExists(product))
            //  throw new Exception("The Product already exists with the same name");


            var tobeUpdated = await _movieContext.Movies.FirstOrDefaultAsync(x => x.Id == movie.Id);
            if (tobeUpdated == null) // checks Product valid
            {
                throw new Exception("can't add enter valid movie name add more details if duplicate exist");
            }
            tobeUpdated.Title = movie.Title;
            _movieContext.Movies.Update(tobeUpdated);
            await _movieContext.SaveChangesAsync();

            return true;
        }
        
        public async Task<Movie> GetMovieAsync(Guid id)
        {

            var movie = await _movieContext.Movies
                                                    .SingleOrDefaultAsync(s => s.Id== id);
            Console.WriteLine(movie.Title);
            if (movie == null)
            {
                throw new Exception($"not found ");
            }

            return movie;
        }
        public async Task<int> DeleteMovieAsync(Guid id)
        {

            //Get the staff who matches with given Id
            var product = await _movieContext.Movies
                                                    .SingleOrDefaultAsync(s => s.Id ==id);
            if (product == null)
            {
                throw new Exception($"The Staff not found for requested Identifier");
            }
            _movieContext.Remove(product);
            await _movieContext.SaveChangesAsync();

            return 1;
        }

        


    }
}
