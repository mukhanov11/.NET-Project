using System;

namespace BookingSystemWeb.Models
{
    public class Seat
    {
        int seatNumber;
        Boolean isReserved;
    
        public Seat(Boolean isReserved, int seatNumber)
        {
            this.isReserved = isReserved;
            this.seatNumber = seatNumber;
        }
    
    
        public void SetSeatNumber(int seatNumber)
        {
            this.seatNumber = seatNumber;
        }
    
        public int GetSeatNumber()
        {
            return this.seatNumber;
        }
    
        public Boolean GetReservationStatus()
        {
            return isReserved;
        }
    
        public void Reserve()
        {
            isReserved = true;
        }
    
        public void Unreserve()
        {
            isReserved = false;
        }   

    }
}