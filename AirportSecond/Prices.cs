using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSecond
{
    public class Prices
    {
        public Dictionary<int, decimal> PriceList;

        public Prices()
        {
            PriceList = new Dictionary<int, decimal>
            {
                {5, 500m},
                {4, 250m},
                {122, 660m},
                {45, 255m},
                {55, 270m},
                {15, 150m},
                {1, 350m},
                {56, 350m},
                {536, 650m},
                {162, 120m},
                {6, 240m},
                {69, 220m},
                {9, 1055m},
                {58, 380m},
            };
        }

        public void AddPrice(int flightNumber, decimal flightPrice)
        {
            PriceList.Add(flightNumber, flightPrice);
        }

        public bool FlightIsPresent(int flightNumber)
        {
            return PriceList.ContainsKey(flightNumber);
        }

        public void ViewPriceTable()
        {
            Console.WriteLine(new string('-', 35));
            Console.WriteLine("|" + "Race Number".PadRight(16) + "|" + "Price".PadRight(16) + "|");
            Console.WriteLine(new string('-', 35));
            foreach (KeyValuePair<int, decimal> keyValue in PriceList)
            {
                Console.WriteLine("|" + keyValue.Key.ToString().PadRight(16) + "|" + keyValue.Value.ToString().PadRight(16) + "|");
            }
            Console.WriteLine(new string('-', 35));
        }
    }
}
