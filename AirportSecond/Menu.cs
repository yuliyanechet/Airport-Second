using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSecond
{
    public class Menu
    {
        public Terminal terminal;

        public Menu()
        {
            terminal = new Terminal();
        }

        public void RunProgram()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please choose the action: ");
                Console.WriteLine("1 - show info (Flight, Price, Passenger)");
                Console.WriteLine("2 - input info (Flight, Price, Passenger)");
                Console.WriteLine("3 - edit info (Flight, Price, Passenger)");
                Console.WriteLine("4 - delete info (Flight, Price, Passenger)");
                Console.WriteLine("5 - search by");
                Console.WriteLine();
                var choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        ShowPannel();
                        break;
                    case "2":
                        InputInfo();
                        break;
                    case "3":
                        EditPannel();
                        break;
                    case "4":
                        DeletePannel();
                        break;
                    case "5":
                        SearchBy();
                        break;
                }
            }
        }

        public void ShowPannel()
        {
            Console.WriteLine("Please choose the action:");
            Console.WriteLine("1 - show Flight Panel");
            Console.WriteLine("2 - show Price Panel");
            Console.WriteLine("3 - show Passenger Panel");
            var showChoice = Console.ReadLine();
            switch (showChoice)
            {
                case "1":
                    terminal.ShowPannel();
                    break;
                case "2":
                    terminal.Price.ViewPriceTable();
                    break;
                case "3":
                    terminal.ShowPassenger();
                    break;
            }
        }
        public void InputInfo()
        {
            Console.WriteLine("Please choose the action:");
            Console.WriteLine("1 - add new Flight");
            Console.WriteLine("2 - add new Price");
            Console.WriteLine("3 - add new Passenger");
            var addChoice = Console.ReadLine();
            switch (addChoice)
            {
                case "1":
                    terminal.AddFlight();
                    break;
                case "2":
                    terminal.AddPrice();
                    break;
                case "3":
                    terminal.AddPessenger();
                    break;
            }
        }
        public void EditPannel()
        {
            Console.WriteLine("Please choose the action:");
            Console.WriteLine("1 - edit Flight");
            Console.WriteLine("2 - edit Price");
            Console.WriteLine("3 - edit Passenger");
            var editChoice = Console.ReadLine();
            switch (editChoice)
            {
                case "1":
                    terminal.EditFlightPanel();
                    break;
                case "2":
                    terminal.EditPricePanel();
                    break;
                case "3":
                    terminal.EditPassangerPannel();
                    break;
            }
        }
        public void DeletePannel()
        {
            Console.WriteLine("Please choose the action:");
            Console.WriteLine("1 - delete Flight");
            Console.WriteLine("2 - delete Price");
            Console.WriteLine("3 - delete Passenger");
            var deleteChoice = Console.ReadLine();
            switch (deleteChoice)
            {
                case "1":
                    terminal.DeleteFlight();
                    break;
                case "2":
                    terminal.DeletePrice();
                    break;
                case "3":
                    terminal.DeletePassenger();
                    break;
            }
        }

        public void SearchBy()
        {
            Console.WriteLine("Please choose the action:");
            Console.WriteLine("1 - search by Flight Number");
            Console.WriteLine("2 - search by Price");
            Console.WriteLine("3 - search by First/Last Name");
            Console.WriteLine("4 - search by Passport");
            Console.WriteLine("5 - search by City");
            var searchChoice = Console.ReadLine();
            switch (searchChoice)
            {
                case "1":
                    terminal.SearchByFlightNumber();
                    break;
                case "2":
                    terminal.SearchByPrice();
                    break;
                case "3":
                    terminal.SearchByFirstLastNames();
                    break;
                case "4":
                    terminal.SearchByPassport();
                    break;
                case "5":
                    terminal.SearchByCity();
                    break;
            }
        }
    }
}
