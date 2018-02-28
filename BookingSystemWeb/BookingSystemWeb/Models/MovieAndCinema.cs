using System.Collections.Generic;

namespace BookingSystemWeb.Models
{
    public class MovieAndCinema
    {
        public List<Movie> Movies { get; set; }
        public List<Cinema> Cinemas { get; set; }
    }
}