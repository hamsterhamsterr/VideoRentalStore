using AutoMapper;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IHttpActionResult GetRentalId(int id, int movieId)
        {
            var rental = _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Movie)
                .SingleOrDefault(r => r.Customer.Id == id && r.Movie.Id == movieId);

            if (rental == null)
                return NotFound();

            return Ok(rental.RentalId);
        }

        [HttpGet]
        public IHttpActionResult GetAmountOfDaysRental(int id)
        {
            var rental = _context.Rentals.SingleOrDefault(r => r.RentalId == id);

            if (rental == null)
                return NotFound();

            var days = (DateTime.Now - rental.DateRented).Days;

            return Ok(days);
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count != newRental.MovieIds.Count)
                return BadRequest("One or more MovieId are invalid.");

            foreach (var movie in movies)
            {
                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }



            _context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult UpdateRental(int id, double discount, [FromBody] int[] movieIds)
        {
            var rentals = _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Customer.MembershipType)
                .Include(r => r.Movie)
                .Where(r => r.Customer.Id == id && movieIds.Contains(r.Movie.Id))
                .ToList();

            if (rentals == null)
                return NotFound();

            var payments = new List<Payment>();

            foreach (var rental in rentals)
            {
                rental.DateReturned = DateTime.Now;
                double amount = 0;
                if (discount > 0 && discount <= 100)
                    amount = Payment.GetTotalPrice(rental.Customer, rental, discount);
                else
                    amount = Payment.GetTotalPrice(rental.Customer, rental, null);

                payments.Add(new Payment
                {
                    Rental = rental,
                    Amount = amount
                });
            }

            _context.Payments.AddRange(payments);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteRental(int id, [FromBody] int[] movieIds)
        {

            var rentals = _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Movie)
                .Where(r => r.Customer.Id == id && movieIds.Contains(r.Movie.Id))
                .ToList();

            if (rentals == null)
                return NotFound();

            _context.Rentals.RemoveRange(rentals);
            _context.SaveChanges();

            return Ok();
        }
    }
}