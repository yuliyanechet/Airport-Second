using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSecond
{
    public enum Nationality
    {
        ukrainian,
        russian,
        american,
        african
    }
    public enum Sex
    {
        male,
        female,
    }

    public enum FlightClass
    {
        business,
        economy,
    }

    public class Passenger
    {
        public Flight PassengerFlight;
        public string FirstName;
        public string SecondName;
        public Nationality Nationality;
        public string Passport;
        public DateTime BirthDay;
        public Sex Sex;
        public FlightClass FlightClass;

        public Passenger(Flight passengerFlight, string firstName, string secondName, Nationality nationality, string passport, DateTime birthDay, Sex sex, FlightClass flightClass)
        {
            PassengerFlight = passengerFlight;
            FirstName = firstName;
            SecondName = secondName;
            Nationality = nationality;
            Passport = passport;
            BirthDay = birthDay;
            Sex = sex;
            FlightClass = flightClass;
        }
    }
}
