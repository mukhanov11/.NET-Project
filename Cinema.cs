using System;
using System.Collections.Generic;
using Remotion.Linq.Parsing.Structure.NodeTypeProviders;

namespace BookingSystemWeb.Models
{
    public class Cinema
    {
        public int cinemaId;
        public String description;
        private int rowCount;
        private List<Row> rows;

        public int ReservedPlaces { get; set; }

        public Cinema(int cinemaId, String description)
        {
            this.ReservedPlaces = 0;
            this.description = description;
            this.cinemaId = cinemaId;
            rows = new List<Row>();
        }

        public void CreateRows(int rowClass, int seatCount, int rowCount)
        {
            for (int i = 1; i <= rowCount; i++)
            {
                rows.Add(new Row(rowClass, seatCount, i));
            }
            this.rowCount += rowCount;
        }

        public List<Row> GetRows()
        {
            return rows;
        }

        public String GetDescription()
        {
            return description;
        }

        public int GetCinemaId()
        {
            return cinemaId;
        }



        public void PrintSeatPlan()
        {
            Console.WriteLine();
            int maxSeatsInRow = 0;
            foreach (Row row in GetRows())
            {
                if (row.GetSeats().Count > maxSeatsInRow)
                {
                    maxSeatsInRow = row.GetSeats().Count;
                }
            }
            Console.Write("   |");
            for (int i = 1; i <= maxSeatsInRow; i++)
            {
                Console.Write(" " + i);
            }
            Console.Write("\n");
            Console.Write("----");
            for (int i = 1; i <= maxSeatsInRow; i++)
            {
                if (i > 9)
                {
                    Console.Write("---");
                }
                else
                {
                    Console.Write("--");
                }
            }
            Console.Write("\n");
            foreach (Row row in GetRows())
            {
                if (row.GetRowNumber() > 9)
                {
                    Console.Write(row.GetRowNumber() + " | ");
                }
                else
                {
                    Console.Write(row.GetRowNumber() + "  | ");
                }
                foreach (Seat seat in row.GetSeats())
                {

                    if (seat.GetReservationStatus())
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(seat.GetSeatNumber() + " ");
                    }
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public int GetTotalRevenue()
        {
            int cnt = 0;

            foreach (Row row in this.rows) {
                for (int i = 0; i < row.GetSeats().Count; i++)
                {
                    if (row.GetSeats()[i].GetReservationStatus()) cnt++;
                }
            }

            return cnt * 8;
        }

        public int GetRevenue() 
        {
            return ReservedPlaces * 8;
        }
        

        public override String ToString()
        {
            return this.description + ":\n" + "Amount of bookings: " + ReservedPlaces + "\nTotal revenue from selled tickets: " + (GetRevenue());
        }

    }
}