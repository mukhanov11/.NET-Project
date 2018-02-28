using System;

namespace BookingSystemWeb.Models
{
    public class MovieForm
    {
        public string MovieDate { get; set; }
        public string MovieName { get; set; }
        public int CinemaId { get; set; }
        public string CinemaName { get; set; }
    }
}