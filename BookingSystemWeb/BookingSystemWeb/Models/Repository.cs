using System.Collections.Generic;

namespace BookingSystemWeb.Models
{
    public class Repository
    {
        public List<Movie> movies = Storage.DesMovies();
        public List<Cinema> cinemas = Storage.DesCinemas();
        public List<Booking> bookings = Storage.DesBookings(); //new List<Booking>();
        public List<Customer> customers = new List<Customer>();

        public Repository()
        {
        }
    }
}