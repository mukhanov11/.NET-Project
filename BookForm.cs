using System;

namespace BookingSystemWeb.Models
{
    public class BookForm
    {
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string MovieName { get; set; }
        public string RowNum { get; set; }
        public string SeatNum { get; set; }
        public string CinemaName { get; set;}
        public string Date { get; set; }
    }
}