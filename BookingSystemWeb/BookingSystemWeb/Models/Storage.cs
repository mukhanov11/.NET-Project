using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BookingSystemWeb.Models
{
    public class Storage
    {
        public static List<Cinema> cinemas = new List<Cinema>();
        public static List<Movie> movies = new List<Movie>();
        public static List<Booking> bookings = new List<Booking>();

        static BinaryFormatter formatter = new BinaryFormatter();

        public static List<Cinema> DesCinemas()
        {
            try
            {
                Stream stream = new FileStream("Cinemas.bin",
                              FileMode.Open,
                              FileAccess.Read,
                              FileShare.Read);
                cinemas = (List<Cinema>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception cnfe)
            {
                cnfe.ToString();
            }
            return cinemas;
        }

        public static List<Movie> DesMovies()
        {
            try
            {
                Stream stream = new FileStream("Movies.bin",
                              FileMode.Open,
                              FileAccess.Read,
                              FileShare.Read);
                movies = (List<Movie>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception cnfe)
            {
                cnfe.ToString();
            }
            return movies;
        }

        public static List<Booking> DesBookings()
        {
            try
            {
                Stream stream = new FileStream("Bookings.bin",
                              FileMode.Open,
                              FileAccess.Read,
                              FileShare.Read);
                bookings = (List<Booking>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception cnfe)
            {
                cnfe.ToString();
            }
            return bookings;
        }

        public static void SerCinemas()
        {
            try
            {
                Stream stream = new FileStream("Cinemas.bin",
                         FileMode.Create,
                         FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, cinemas);
                stream.Close();
            }
            catch (IOException ioe)
            {
                ioe.ToString();
            }
        }

        public static void SerMovies()
        {
            try
            {
                Stream stream = new FileStream("Movies.bin",
                         FileMode.Create,
                         FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, movies);
                stream.Close();
            }
            catch (IOException ioe)
            {
                ioe.ToString();
            }
        }

        public static void SerBookings()
        {
            try
            {
                Stream stream = new FileStream("Bookings.bin",
                        FileMode.Create,
                        FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, bookings);
                stream.Close();
            }
            catch (IOException ioe)
            {
                ioe.ToString();
            }
        }

    }
}