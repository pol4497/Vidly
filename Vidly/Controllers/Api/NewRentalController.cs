using System;
using System.Linq;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;
using Vidly.Models.Identity_Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _contex;

        public NewRentalController()
        {
            _contex = new ApplicationDbContext();
        }

        //Post Rental
        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {
            var customer = _contex.Customers.Single(c => c.Id == newRental.CustomerId);

            var movies = _contex.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable > 0)
                {
                    var rental = new Rental
                    {
                        Customer = customer,
                        Movie = movie,
                        DateRented = DateTime.Now
                    };

                    _contex.Rentals.Add(rental);

                    movie.NumberAvailable--;
                }
                else
                {
                    return BadRequest("Movie is not available.");
                }
                
            }

            _contex.SaveChanges();

            return Ok();
        }
    }
}
