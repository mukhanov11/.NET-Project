using System;

namespace BookingSystemWeb.Models
{
    public class BookForm
    {
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string MovieId { get; set; }
        public string RowNum { get; set; }
        public string SeatNum { get; set; }
    }
}