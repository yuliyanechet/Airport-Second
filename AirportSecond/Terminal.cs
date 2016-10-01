using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSecond
{
    public class Terminal
    {
        public List<Flight> arrivals;
        private List<Flight> departures;
        public Prices Price;
        public List<Passenger> passengers;

        public Terminal()
        {
            arrivals = new List<Flight>();
            departures = new List<Flight>();
            Price = new Prices();
            passengers = new List<Passenger>();
            AddArrivalFlight(new Flight(Convert.ToDateTime("21/08/2016 23:29:50.42"), 5, "Antalia", "Air Alps Aviation", 1, Status.Arrived));
            AddArrivalFlight(new Flight(Convert.ToDateTime("13/08/2016 15:50:50.42"), 4, "Rimini", "Air Berlin", 2, Status.Delayed));
            AddArrivalFlight(new Flight(Convert.ToDateTime("13/08/2016 17:20:50.42"), 122, "Krakov", "Air Bucharest", 5, Status.Arrived));
            AddArrivalFlight(new Flight(Convert.ToDateTime("13/08/2016 18:25:50.42"), 45, "Stambul", "Air Italy Polska", 6, Status.In_flight));
            AddArrivalFlight(new Flight(Convert.ToDateTime("13/08/2016 19:55:50.42"), 55, "Kiev", "Carpatair", 3, Status.In_flight));
            AddArrivalFlight(new Flight(Convert.ToDateTime("13/08/2016 22:50:50.42"), 15, "Tivat", "Contact Air Flugdienst", 8, Status.Unknown));
            AddArrivalFlight(new Flight(Convert.ToDateTime("13/08/2016 23:55:50.42"), 1, "Dalaman", "Direct Aero Services", 9, Status.In_flight));

            AddDepartureFlight(new Flight(Convert.ToDateTime("13/08/2016 10:50:50.42"), 56, "Dalaman", "Air Italy Polska", 1, Status.Delayed));
            AddDepartureFlight(new Flight(Convert.ToDateTime("13/08/2016 11:15:50.42"), 536, "Tivat", "Air Berlin", 2, Status.Expected_at));
            AddDepartureFlight(new Flight(Convert.ToDateTime("13/08/2016 12:20:50.42"), 162, "Kiev", "Direct Aero Services", 5, Status.Expected_at));
            AddDepartureFlight(new Flight(Convert.ToDateTime("13/08/2016 16:25:50.42"), 6, "Stambul", "Air Italy Polska", 6, Status.Expected_at));
            AddDepartureFlight(new Flight(Convert.ToDateTime("13/08/2016 19:55:50.42"), 69, "Krakov", "Carpatair", 3, Status.Expected_at));
            AddDepartureFlight(new Flight(Convert.ToDateTime("13/08/2016 22:40:50.42"), 9, "Rimini", "Contact Air Flugdienst", 8, Status.Canceled));
            AddDepartureFlight(new Flight(Convert.ToDateTime("13/08/2016 23:50:50.42"), 58, "Antalia", "Direct Aero Services", 9, Status.Arrived));

            passengers.Add(new Passenger(arrivals[0], "Alex", "Kaverin", Nationality.russian, "PO45456", Convert.ToDateTime("13/08/1970 10:50:50.42"), Sex.male, FlightClass.business));
            passengers.Add(new Passenger(arrivals[0], "Alina", "Kaverina", Nationality.ukrainian, "GH44564", Convert.ToDateTime("12/08/1970 10:50:50.42"), Sex.female, FlightClass.business));
            passengers.Add(new Passenger(arrivals[0], "Bernard", "Meison", Nationality.russian, "GHG5446", Convert.ToDateTime("5/08/1970 10:50:50.42"), Sex.male, FlightClass.economy));
            passengers.Add(new Passenger(arrivals[2], "Ben", "Soviet", Nationality.african, "HUJ45546", Convert.ToDateTime("14/08/1970 10:50:50.42"), Sex.male, FlightClass.business));
            passengers.Add(new Passenger(arrivals[2], "Kate", "Main", Nationality.african, "AGH44556", Convert.ToDateTime("8/08/1970 10:50:50.42"), Sex.female, FlightClass.economy));
            passengers.Add(new Passenger(departures[2], "Fil", "Offer", Nationality.ukrainian, "ADS78456", Convert.ToDateTime("19/08/1970 10:50:50.42"), Sex.male, FlightClass.business));
            passengers.Add(new Passenger(departures[2], "Dino", "Valid", Nationality.american, "GG6856", Convert.ToDateTime("13/06/1970 10:50:50.42"), Sex.male, FlightClass.economy));
            passengers.Add(new Passenger(departures[2], "Fabric", "Bush", Nationality.american, "AK448996", Convert.ToDateTime("16/06/1970 10:50:50.42"), Sex.male, FlightClass.business));
        }
        public void ShowPannel()
        {
            Console.WriteLine(new string('-', 96));
            Console.WriteLine("|" + "Date".PadRight(20) + "|" + "Number".PadRight(7) + "|" + "City".PadRight(15) + "|" + "Airline".PadRight(23) + "|" + "Terminal".PadRight(9) + "|" + "Status".PadRight(15) + "|");
            Console.WriteLine(new string('-', 96));
            Console.WriteLine("|" + "Arrivals".PadRight(94) + "|");
            Console.WriteLine(new string('-', 96));
            foreach (var line in arrivals)
            {
                string output = "|";
                output += (line.Date.ToString()).PadRight(20) + "|";
                output += (line.Number.ToString()).PadRight(7) + "|";
                output += (line.City.ToString()).PadRight(15) + "|";
                output += (line.Airline.ToString()).PadRight(23) + "|";
                output += (line.Terminal.ToString()).PadRight(9) + "|";
                output += (line.Status.ToString()).PadRight(15) + "|";
                Console.WriteLine(output);
            }
            Console.WriteLine(new string('-', 96));
            Console.WriteLine("|" + "Departures".PadRight(94) + "|");
            Console.WriteLine(new string('-', 96));
            foreach (var line in departures)
            {
                string output = "|";
                output += (line.Date.ToString()).PadRight(20) + "|";
                output += (line.Number.ToString()).PadRight(7) + "|";
                output += (line.City.ToString()).PadRight(15) + "|";
                output += (line.Airline.ToString()).PadRight(23) + "|";
                output += (line.Terminal.ToString()).PadRight(9) + "|";
                output += (line.Status.ToString()).PadRight(15) + "|";
                Console.WriteLine(output);
            }
            Console.WriteLine(new string('-', 96));
            Console.WriteLine();
        }

        public void ShowSearchResults(List<Flight> localArrivals, List<Flight> localDepartures)
        {
            Console.WriteLine(new string('-', 96));
            Console.WriteLine("|" + "Date".PadRight(20) + "|" + "Number".PadRight(7) + "|" + "City".PadRight(15) + "|" + "Airline".PadRight(23) + "|" + "Terminal".PadRight(9) + "|" + "Status".PadRight(15) + "|");
            Console.WriteLine(new string('-', 96));
            if (localArrivals.Count != 0)
            {
                Console.WriteLine("|" + "Arrivals".PadRight(94) + "|");
                Console.WriteLine(new string('-', 96));

                foreach (var line in localArrivals)
                {
                    string output = "|";
                    output += (line.Date.ToString()).PadRight(20) + "|";
                    output += (line.Number.ToString()).PadRight(7) + "|";
                    output += (line.City.ToString()).PadRight(15) + "|";
                    output += (line.Airline.ToString()).PadRight(23) + "|";
                    output += (line.Terminal.ToString()).PadRight(9) + "|";
                    output += (line.Status.ToString()).PadRight(15) + "|";
                    Console.WriteLine(output);
                }
                Console.WriteLine(new string('-', 96));
            }
            if (localDepartures.Count != 0)
            {
                Console.WriteLine("|" + "Departures".PadRight(94) + "|");
                Console.WriteLine(new string('-', 96));
                foreach (var line in localDepartures)
                {
                    string output = "|";
                    output += (line.Date.ToString()).PadRight(20) + "|";
                    output += (line.Number.ToString()).PadRight(7) + "|";
                    output += (line.City.ToString()).PadRight(15) + "|";
                    output += (line.Airline.ToString()).PadRight(23) + "|";
                    output += (line.Terminal.ToString()).PadRight(9) + "|";
                    output += (line.Status.ToString()).PadRight(15) + "|";
                    Console.WriteLine(output);
                }
                Console.WriteLine(new string('-', 96));
                Console.WriteLine();
            }
        }

        void PrintPassenger(Passenger passenger)
        {
            string output = "|";
            output += (passenger.PassengerFlight.Number.ToString()).PadRight(11) + "|";
            output += (passenger.FirstName.PadRight(15)) + "|";
            output += (passenger.SecondName.PadRight(15)) + "|";
            output += (passenger.Nationality.ToString().PadRight(15)) + "|";
            output += (passenger.Passport.PadRight(10)) + "|";
            output += (passenger.BirthDay.ToString().PadRight(20)) + "|";
            output += (passenger.Sex.ToString().PadRight(10)) + "|";
            output += (passenger.FlightClass.ToString().PadRight(10)) + "|";
            Console.WriteLine(output);
        }
        public void ShowPassenger(Passenger passenger = null)
        {
            Console.WriteLine(new string('-', 114));
            Console.WriteLine("|" + "Race Number".PadRight(10) + "|" + "First Name".PadRight(15) + "|" + "Second Name".PadRight(15) + "|" + "Nationality".PadRight(15) + "|" + "Passport".PadRight(10) + "|" + "BirthDay".PadRight(20) + "|" + "Sex".PadRight(10) + "|" + "Class".PadRight(10) + "|");
            Console.WriteLine(new string('-', 114));
            if (passenger == null)
            {
                foreach (var line in passengers)
                {
                    PrintPassenger(line);
                }
            }
            else
            {
                PrintPassenger(passenger);
            }
            Console.WriteLine(new string('-', 114));
        }

        public void AddArrivalFlight(Flight flight)
        {
            arrivals.Add(flight);
        }

        public void AddDepartureFlight(Flight flight)
        {
            departures.Add(flight);
        }

        public void AddFlight()
        {
            Console.WriteLine("Please enter:");
            Console.WriteLine("1 - for adding new flight to arrivels panel");
            Console.WriteLine("2 - for adding new flight to departures panel");
            var panelChoice = Console.ReadLine();
            Console.WriteLine("Enter date/time in the folowing format dd/mm/yyyy hh:mm:ss");
            var date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter flight number");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter City");
            var city = Console.ReadLine();
            Console.WriteLine("Enter Airline");
            var airline = Console.ReadLine();
            Console.WriteLine("Enter Terminal");
            var terminal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Status:");
            Console.WriteLine("1 - Check_in");
            Console.WriteLine("2 - GateClosed");
            Console.WriteLine("3 - Arrived");
            Console.WriteLine("4 - Departed_at");
            Console.WriteLine("5 - Unknown");
            Console.WriteLine("6 - Canceled");
            Console.WriteLine("7 - Expected_at");
            Console.WriteLine("8 - Delayed");
            Console.WriteLine("9 - In_flight");
            var tempStatus = Console.ReadLine();
            var statusForAddInfo = new Status[] { Status.Check_in, Status.GateClosed, Status.Arrived, Status.Departed_at, Status.Unknown, Status.Canceled, Status.Expected_at, Status.Delayed, Status.In_flight };

            var currentFlight = new Flight(date, number, city, airline, terminal, statusForAddInfo[Int32.Parse(tempStatus) - 1]);
            if (panelChoice == "1")
            {
                AddArrivalFlight(currentFlight);
            }
            if (panelChoice == "2")
            {
                AddDepartureFlight(currentFlight);
            }
        }

        public void AddPrice()
        {
            Console.WriteLine("Enter flight number");
            var flightnumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter price of this flight");
            var flightPrice = Decimal.Parse(Console.ReadLine());
            Price.AddPrice(flightnumber, flightPrice);
        }

        public void AddPessenger()
        {
            Console.WriteLine("Please enter the Flight Number");
            var flightnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Name");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter Second Name");
            var secondName = Console.ReadLine();
            Console.WriteLine("Choose Nationality");
            Console.WriteLine("1 - african");
            Console.WriteLine("2 - american");
            Console.WriteLine("3 - russian");
            Console.WriteLine("4 - ukrainian");
            var nationalityChoice = Console.ReadLine();
            var nationalityList = new Nationality[] { Nationality.african, Nationality.american, Nationality.russian, Nationality.ukrainian };
            var nationality = nationalityList[Int32.Parse(nationalityChoice) - 1];
            Console.WriteLine("Enter Passport Number");
            var passport = Console.ReadLine();
            Console.WriteLine("Enter Birthday");
            var datebirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Choose Sex");
            Console.WriteLine("1 - female");
            Console.WriteLine("2 - male");
            var sexChoice = Console.ReadLine();
            var sexList = new Sex[] { Sex.female, Sex.male };
            var sex = sexList[Int32.Parse(sexChoice) - 1];
            Console.WriteLine("Choose Class");
            Console.WriteLine("1 - business");
            Console.WriteLine("2 - economy");
            var flightclassChoice = Console.ReadLine();
            var flightclassList = new FlightClass[] { FlightClass.business, FlightClass.economy };
            var flightclass = flightclassList[Int32.Parse(flightclassChoice) - 1];
            var currentArrivels = arrivals.Where(c => c.Number == flightnumber).ToList();
            var currentDepartures = departures.Where(c => c.Number == flightnumber).ToList();

            var currentPassenger = new Passenger(currentArrivels.Count > 0 ? currentArrivels.FirstOrDefault() : currentDepartures.FirstOrDefault(), firstName, secondName, nationality, passport, datebirth, sex, flightclass);
            passengers.Add(currentPassenger);
        }

        public void EditFlightPanel()
        {
            Console.WriteLine("Enter flight number you want to edit: ");
            int editFlifghtNumber = Convert.ToInt32(Console.ReadLine());
            Flight currentFlight = arrivals[0];
            foreach (var item in arrivals.Concat(departures))
            {
                if (editFlifghtNumber == item.Number)
                {
                    currentFlight = item;
                    break;
                }
            }
            Console.WriteLine("Enter new Data value in the folowing format dd/mm/yyyy hh:mm:ss or click Enter to skip");
            string newDate = Console.ReadLine();
            if (newDate != "")
            {
                currentFlight.Date = Convert.ToDateTime(newDate);
            }
            Console.WriteLine("Enter new flight Number or click Enter to skip");
            string newNumber = Console.ReadLine();
            if (newNumber != "")
            {
                currentFlight.Number = Convert.ToInt32(newNumber);
            }
            Console.WriteLine("Enter new City or click Enter to skip");
            string newCity = Console.ReadLine();
            if (newCity != "")
            {
                currentFlight.City = newCity;
            }
            Console.WriteLine("Enter new Airline or click Enter to skip");
            string newAirline = Console.ReadLine();
            if (newAirline != "")
            {
                currentFlight.Airline = newAirline;
            }
            Console.WriteLine("Enter new Terminal or click Enter to skip");
            string newTerminal = Console.ReadLine();
            if (newTerminal != "")
            {
                currentFlight.Terminal = Convert.ToInt32(newTerminal);
            }
            Console.WriteLine("Please enter Status:");
            Console.WriteLine("1 - Check_in");
            Console.WriteLine("2 - GateClosed");
            Console.WriteLine("3 - Arrived");
            Console.WriteLine("4 - Departed_at");
            Console.WriteLine("5 - Unknown");
            Console.WriteLine("6 - Canceled");
            Console.WriteLine("7 - Expected_at");
            Console.WriteLine("8 - Delayed");
            Console.WriteLine("9 - In_flight");
            string newStatus = Console.ReadLine();

            var statusForEditInfo = new Status[] { Status.Check_in, Status.GateClosed, Status.Arrived, Status.Departed_at, Status.Unknown, Status.Canceled, Status.Expected_at, Status.Delayed, Status.In_flight };

            if (newStatus != "")
            {
                currentFlight.Status = statusForEditInfo[Int32.Parse(newStatus) - 1];
            }

        }

        public void EditPricePanel()
        {
            Console.WriteLine("Enter flight number you want to edit: ");
            int editFlifghtNumber = Convert.ToInt32(Console.ReadLine());
            foreach (var item in Price.PriceList)
            {
                if (editFlifghtNumber == item.Key)
                {
                    Console.WriteLine("Enter new Price");
                    var newPrice = Convert.ToDecimal(Console.ReadLine());
                    Price.PriceList[item.Key] = newPrice;
                    break;
                }
            }
        }

        public void EditPassangerPannel()
        {
            Console.WriteLine("Enter Passport Number: ");
            var editPassportNumber = (Console.ReadLine());
            Passenger currentPassenger = passengers[0];
            foreach (var item in passengers)
            {
                if (editPassportNumber == item.Passport)
                {
                    currentPassenger = item;
                    break;
                }
            }
            Console.WriteLine("Please enter new Flight Number or click Enter to skip");
            var flightnumber = Console.ReadLine();
            if (flightnumber != "")
            {
                currentPassenger.PassengerFlight.Number = Int32.Parse(flightnumber);
            }
            Console.WriteLine("Enter new First Name or click Enter to skip");
            var firstName = Console.ReadLine();
            if (firstName != "")
            {
                currentPassenger.FirstName = firstName;
            }
            Console.WriteLine("Enter Second Name or click Enter to skip");
            var secondName = Console.ReadLine();
            if (secondName != "")
            {
                currentPassenger.SecondName = secondName;
            }
            Console.WriteLine("Choose Nationality or click Enter to skip");
            Console.WriteLine("1 - african");
            Console.WriteLine("2 - american");
            Console.WriteLine("3 - russian");
            Console.WriteLine("4 - ukrainian");
            var nationalityChoice = Console.ReadLine();
            if (nationalityChoice != "")
            {
                var nationalityList = new Nationality[] { Nationality.african, Nationality.american, Nationality.russian, Nationality.ukrainian };
                var nationality = nationalityList[Int32.Parse(nationalityChoice) - 1];
                currentPassenger.Nationality = nationality;
            }
            Console.WriteLine("Enter Passport Number or click Enter to skip");
            var passport = Console.ReadLine();
            if (passport != "")
            {
                currentPassenger.Passport = passport;
            }
            Console.WriteLine("Enter Birthday or click Enter to skip");
            var datebirth = Console.ReadLine();
            if (datebirth != "")
            {
                currentPassenger.BirthDay = Convert.ToDateTime(datebirth);
            }
            Console.WriteLine("Choose Sex or click Enter to skip");
            Console.WriteLine("1 - female");
            Console.WriteLine("2 - male");
            var sexChoice = Console.ReadLine();
            if (sexChoice != "")
            {
                var sexList = new Sex[] { Sex.female, Sex.male };
                var sex = sexList[Int32.Parse(sexChoice) - 1];
                currentPassenger.Sex = sex;

            }
            Console.WriteLine("Choose Class or click Enter to skip");
            Console.WriteLine("1 - business");
            Console.WriteLine("2 - economy");
            var flightclassChoice = Console.ReadLine();
            if (flightclassChoice != "")
            {
                var flightclassList = new FlightClass[] { FlightClass.business, FlightClass.economy };
                var flightclass = flightclassList[Int32.Parse(flightclassChoice) - 1];
                currentPassenger.FlightClass = flightclass;
            }
        }

        public void DeleteFlight()
        {
            Console.WriteLine("Enter flight number you want to delete: ");
            int deleteFlifghtNumber = Convert.ToInt32(Console.ReadLine());
            foreach (var item in arrivals.Concat(departures))
            {
                if (deleteFlifghtNumber == item.Number)
                {
                    arrivals.Remove(item);
                    departures.Remove(item);
                    Console.WriteLine("Record has been succesfully deleted");
                    break;
                }
            }
        }

        public void DeletePrice()
        {
            Console.WriteLine("Enter flight number you want to delete: ");
            int deletePriceNumber = Convert.ToInt32(Console.ReadLine());
            foreach (var item in Price.PriceList)
            {
                if (deletePriceNumber == item.Key)
                {
                    Price.PriceList.Remove(item.Key);
                    Console.WriteLine("Record has been succesfully deleted");
                    break;
                }
            }
        }

        public void DeletePassenger()
        {
            Console.WriteLine("Enter Passport Number: ");
            var editPassportNumber = (Console.ReadLine());
            foreach (var item in passengers)
            {
                if (editPassportNumber == item.Passport)
                {
                    passengers.Remove(item);
                    Console.WriteLine("Record has been succesfully deleted");
                    break;
                }
            }
        }

        public void SearchByFlightNumber()
        {
            Console.WriteLine("Enter Flight Number: ");
            var searchFlightNumber = Convert.ToInt32((Console.ReadLine()));
            var currentArrivels = new List<Flight>();
            var currentDepartures = new List<Flight>();
            currentArrivels = arrivals.Where(c => c.Number == searchFlightNumber).ToList();
            currentDepartures = departures.Where(c => c.Number == searchFlightNumber).ToList();
            ShowSearchResults(currentArrivels, currentDepartures);
        }

        public void SearchByPrice()
        {
            Console.WriteLine("Enter Price: ");
            decimal searchbyPrice = Convert.ToDecimal(Console.ReadLine());
            var currentArrivels = new List<Flight>();
            var currentDepartures = new List<Flight>();
            foreach (var item in Price.PriceList)
            {
                if (searchbyPrice == item.Value)
                {
                    currentArrivels = arrivals.Where(c => c.Number == item.Key).ToList();
                    currentDepartures = departures.Where(c => c.Number == item.Key).ToList();
                    break;
                }
            }
            ShowSearchResults(currentArrivels, currentDepartures);
        }
        public void SearchByFirstLastNames()
        {
            Console.WriteLine("Please enter First Name:");
            string searchFirstName = Console.ReadLine();
            Console.WriteLine("Please enter Last Name:");
            string searchLasttName = Console.ReadLine();
            foreach (var item in passengers)
            {
                if (searchFirstName == item.FirstName && searchLasttName == item.SecondName)
                {
                    ShowPassenger(item);
                }
            }
        }

        public void SearchByPassport()
        {
            Console.WriteLine("Enter Passport Number: ");
            var searchPassportNumber = (Console.ReadLine());
            foreach (var item in passengers)
            {
                if (searchPassportNumber == item.Passport)
                {
                    ShowPassenger(item);
                }
            }
        }
        public void SearchByCity()
        {
            Console.WriteLine("Enter City: ");
            var searchByCity = Console.ReadLine();
            var currentArrivels = new List<Flight>();
            var currentDepartures = new List<Flight>();
            currentArrivels = arrivals.Where(c => c.City == searchByCity).ToList();
            currentDepartures = departures.Where(c => c.City == searchByCity).ToList();
            ShowSearchResults(currentArrivels, currentDepartures);
        }
    }
}
