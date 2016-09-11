using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSecond
{
    public enum Status
    {
        Check_in,
        GateClosed,
        Arrived,
        Departed_at,
        Unknown,
        Canceled,
        Expected_at,
        Delayed,
        In_flight,
    };

    public class Flight
    {
        public DateTime Date;
        public int Number;
        public string City;
        public string Airline;
        public int Terminal;
        public Status Status;

        public Flight(DateTime data, int number, string city, string airline, int terminal, Status status)
        {
            Date = data;
            Number = number;
            City = city;
            Airline = airline;
            Terminal = terminal;
            Status = status;
        }
    }
}

