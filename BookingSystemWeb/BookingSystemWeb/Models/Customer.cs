using System;

namespace BookingSystemWeb.Models
{
    public class Customer
    {
        int id;
        String name;
        String surname;
        String street;
        int streetNumber;
        int plz;
        String city;

        public Customer(int id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }

        public int GetId()
        {
            return id;
        }

        public string GetName(){
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public void SetSurname(String surname)
        {
            this.surname = surname;
        }

        public void SetStreet(String street)
        {
            this.street = street;
        }

        public void SetStreetNumber(int streetNumber)
        {
            this.streetNumber = streetNumber;
        }

        public void SetPLZ(int plz)
        {
            this.plz = plz;
        }

        public void SetCity(String city)
        {
            this.city = city;
        }

        public void PrintCostumer()
        {
            Console.WriteLine(surname + " " + name);
            Console.WriteLine(street + " " + streetNumber);
            Console.WriteLine(plz + " " + city);
        }

    }
}