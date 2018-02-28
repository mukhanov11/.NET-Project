using System;
using System.Collections.Generic;

namespace BookingSystemWeb.Models
{
    public class Movie
    {
        public String movieName;
        private String movieDate;
        public Cinema cinema;
        private List<Seat> seats;
        private int freeSeats;

        public Movie(String movieName, String movieDate, Cinema cinema)
        {
            this.movieName = movieName;
            this.movieDate = movieDate;
            this.cinema = cinema;
        }

        public void LoadSeats()
        {
            foreach (Row row in cinema.GetRows())
            {
                foreach (Seat seat in row.GetSeats())
                {
                    seats.Add(seat);
                }
            }
        }

        public int GetFreeSeatsCount()
        {
            foreach (Seat seat in seats)
            {
                if (!seat.GetReservationStatus())
                {
                    freeSeats++;
                }
            }
            return freeSeats;
        }


        public void SetMovieName(String movieName)
        {
            this.movieName = movieName;
        }

        public void SetMovieDate(String movieDate)
        {
            this.movieDate = movieDate;
        }

        public void SetCinema(Cinema cinema)
        {
            this.cinema = cinema;
        }

        public String GetMovieName()
        {
            return movieName;
        }

        public String GetMovieDate()
        {
            return movieDate;
        }

        public Cinema GetCinema()
        {
            return cinema;
        }

        public List<Seat> GetSeats()
        {
            return seats;
        }

    }
}