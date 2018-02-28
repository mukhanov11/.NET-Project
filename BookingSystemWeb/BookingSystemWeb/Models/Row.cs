using System.Collections.Generic;

namespace BookingSystemWeb.Models
{
    public class Row
    {
        private List<Seat> seats;
        private int rowNumber;
        private int rowClass;
        private int seatCount;

        public Row(int rowClass, int seatCount, int rowNumber)
        {
            this.rowNumber = rowNumber;
            this.rowClass = rowClass;
            this.seatCount = seatCount;
            seats = new List<Seat>();
            CreateSeats(this.seatCount);
        }

        public void SetRowClass(int rowClass)
        {
            this.rowClass = rowClass;
        }

        public int GetRowClass()
        {
            return this.rowClass;
        }

        public int GetRowNumber()
        {
            return rowNumber;
        }

        public void CreateSeats(int seatCount)
        {
            for (int i = 1; i <= seatCount; i++)
            {
                seats.Add(new Seat(false, i));
            }
        }

        public List<Seat> GetSeats()
        {
            return seats;
        }

    }
}