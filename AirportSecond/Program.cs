using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            var terminal = new Terminal();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please choose the action: ");
                Console.WriteLine("1 - show info (Flight, Price, Passenger)");
                Console.WriteLine("2 - input info (Flight, Price, Passenger)");
                Console.WriteLine("3 - edit info (Flight, Price, Passenger)");
                Console.WriteLine("4 - delete info (Flight, Price, Passenger)");
                Console.WriteLine("5 - search by");
                Console.WriteLine("6 - search the nearest flight");
                Console.WriteLine();
                //bool noResultFound = true;
                var choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
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
                        break;
                    case "2":
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
                        break;
                    case "3":
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
                        break;
                    case "4":
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
                        break;

                }
            }
        }
    }
}



