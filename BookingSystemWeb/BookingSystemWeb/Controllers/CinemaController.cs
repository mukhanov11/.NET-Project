using System;
using BookingSystemWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingSystemWeb.Controllers
{
    public class CinemaController : Controller
    {
        private Repository repo;
        public CinemaController()
        {
            repo = new Repository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            Console.WriteLine("Hello from index");
            return View(repo.cinemas);
        }


        [HttpPost]
        public IActionResult Index(CinemaForm form)
        {
            Cinema testCinema = new Cinema(form.CinemaId, form.CinemaName);
            testCinema.CreateRows(1, 10, form.RowCount);
            repo.cinemas.Add(testCinema);
            form = new CinemaForm();
            return View(repo.cinemas);
        }

        [HttpGet]
        public IActionResult Movie()
        {
            return View(repo.movies);
        }

        [HttpPost]
        public IActionResult Movie(MovieForm form)
        {
            var cinema = repo.cinemas.Find(x => x.GetCinemaId().Equals(form.CinemaId));
            repo.movies.Add(new Movie(form.MovieName, form.MovieDate, cinema));
            return View(repo.movies);
        }

        [HttpGet]
        public IActionResult Book()
        {
            return View(repo.bookings);
        }

        [HttpPost]
        public IActionResult Book(BookForm form)
        {
            Customer c = new Customer(1, form.ClientName, form.ClientSurname);
            repo.bookings.Add(new Booking(c, new Movie("ASD", "asd", new Cinema(1, "test"))));
//            repo.bookings.Add();
            return View(repo.bookings);
        }
    }
}