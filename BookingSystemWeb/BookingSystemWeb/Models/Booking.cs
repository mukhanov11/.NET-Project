using System;

namespace BookingSystemWeb.Models
{
    public class Booking
    {
        int cost;
        Customer costumer;
        Movie movie;
        int rowNumber;
        int seatNumber;

        public Booking(Customer costumer, Movie movie)
        {
            this.costumer = costumer;
            this.movie = movie;
        }

        public int GetCost()
        {
            if (movie.GetCinema().GetRows()[rowNumber].GetRowClass() == 1)
            
            {
                return cost += 8;
            }
            else
            {
                return cost += 5;
            }
        }

        public void SetRowNumber(int rowNumber)
        {
            this.rowNumber = rowNumber;
        }

        public void SetSeatNumber(int seatNumber)
        {
            this.seatNumber = seatNumber;
        }

        public Boolean ReserveSeat(int selectedRow, int selectedSeat)
        {
            if (movie.GetCinema().GetRows()[selectedRow].GetSeats()[selectedSeat].GetReservationStatus())
            {
                return false;
            }
            else
            {
                movie.GetCinema().GetRows()[selectedRow].GetSeats()[selectedSeat].Reserve();
                SetRowNumber(selectedRow);
                SetSeatNumber(selectedSeat);
                movie.cinema.ReservedPlaces += 1;
                return true;
            }
        }

        public Boolean UnreserveSeat()
        {
            movie.GetCinema().GetRows()[rowNumber].GetSeats()[seatNumber].Unreserve();
            return true;
        }

        public Customer GetCostumer()
        {
            return costumer;
        }
    }
}